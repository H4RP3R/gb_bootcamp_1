from flask import Flask, render_template
from reg import RegisterForm


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
    return render_template('auth.html', title='Authentication')


@app.route('/register', methods=['GET', 'POST'])
def register():
    form = RegisterForm()
    if form.validate_on_submit():
        with open('db.txt', 'a', encoding='utf-8') as f:
            f.write(f'{form.data["name"]};{form.data["email"]};{form.data["password"]}\n')
        return render_template('index.html', message='You have successfully registered')
    return render_template('register.html', title='Create Account', form=form)


if __name__ == '__main__':
    app.run()
