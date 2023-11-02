from flask import Flask, render_template, session, flash, redirect, url_for
from reg import RegisterForm, LoginForm

from utils import get_user


app = Flask(__name__)
app.static_folder = 'static'
app.config['SECRET_KEY'] = 'Ieyei2ung4Aesie0'


@app.route('/', methods=['get'])
def main():
    return render_template('index.html', title='Main Page')


@app.route('/info', methods=['get'])
def info():
    students = ['Ivan', 'Lisa', 'Mark', 'Tom', 'Ann', 'Donna', 'Mary']
    return render_template('info.html', title='Info', names=students)


@app.route('/condition/<x>/<y>')
def condition(x, y):
    return render_template('condition.html', title='Compare Numbers', x=int(x), y=int(y))


@app.route('/auth', methods=['GET', 'POST'])
def auth():
    form = LoginForm()
    if form.validate_on_submit():
        user = get_user(form.data['name'], form.data['password'])
        if user:
            session['loggedin'] = True
            session['username'] = user.username
            flash('You have successfully logged in!')
            return redirect(url_for('main'))
        else:
            flash('Invalid username or password')

    return render_template('auth.html', title='Authentication', form=form)


@app.route('/register', methods=['GET', 'POST'])
def register():
    form = RegisterForm()
    if form.validate_on_submit():
        with open('db.txt', 'a', encoding='utf-8') as f:
            f.write(f'{form.data["name"]};{form.data["email"]};{form.data["password"]}\n')
        return render_template('index.html', message='You have successfully registered')
    return render_template('register.html', title='Create Account', form=form)


@app.route('/logout')
def logout():
    session.pop('loggedin', None)
    session.pop('id', None)
    return redirect(url_for('auth'))


if __name__ == '__main__':
    app.run()
