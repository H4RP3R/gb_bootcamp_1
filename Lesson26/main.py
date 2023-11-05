from flask import Flask, render_template, session, flash, redirect, url_for
from flask_login import login_user
from werkzeug.security import generate_password_hash
from sqlalchemy.exc import IntegrityError

from reg import RegisterForm, LoginForm
from data import db_session, users


app = Flask(__name__)
app.static_folder = 'static'
app.config['SECRET_KEY'] = 'Ieyei2ung4Aesie0'


@app.route('/', methods=['GET'])
def main():
    return render_template('index.html', title='Main Page')


@app.route('/info', methods=['GET'])
def info():
    students = ['Ivan', 'Lisa', 'Mark', 'Tom', 'Ann', 'Donna', 'Mary']
    return render_template('info.html', title='Info', names=students)


@app.route('/condition/<x>/<y>')
def condition(x, y):
    return render_template('condition.html', title='Compare Numbers', x=int(x), y=int(y))


@app.route('/auth', methods=['GET', 'POST'])
def auth():
    db_session.global_init('db/app.db')
    form = LoginForm()
    if form.validate_on_submit():
        sessions = db_session.create_session()
        user = sessions.query(users.User).filter(users.User.name == form.name.data).first()
        if user and user.check_password(form.password.data):
            session['loggedin'] = True
            session['username'] = user.name
            flash('You have successfully logged in!')
            return redirect(url_for('main'))
        else:
            flash('Invalid username or password')
    return render_template('auth.html', title='Authentication', form=form)


@app.route('/register', methods=['GET', 'POST'])
def register():
    db_session.global_init('db/app.db')
    form = RegisterForm()
    if form.validate_on_submit():
        sessions = db_session.create_session()
        try:
            user = users.User(
                name=form.name.data,
                email=form.email.data,
                password=generate_password_hash(form.password.data)
            )
            user.set_password(form.password.data)
            sessions.add(user)
            sessions.commit()
            return render_template('index.html', message='You have successfully registered')
        except IntegrityError:
            flash('This user already exists!')
    return render_template('register.html', title='Create Account', form=form)


@app.route('/logout')
def logout():
    session.pop('loggedin', None)
    session.pop('id', None)
    flash('You have successfully logged out!')
    return redirect(url_for('auth'))


if __name__ == '__main__':
    app.run()
