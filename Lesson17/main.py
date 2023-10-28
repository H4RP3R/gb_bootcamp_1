from flask import Flask, render_template


app = Flask(__name__)
app.static_folder = 'static'


@app.route('/', methods=['get'])
def main():
    return render_template('index.html', title='Main Page')


@app.route('/info', methods=['get'])
def info():
    students = ['Ivan', 'Lisa', 'Mark', 'Tom', 'Ann', 'Donna', 'Mary']
    return render_template('info.html', title='Info', names=students)


@app.route('/condition/<x>/<y>')
def summ(x, y):
    return render_template('condition.html', title='Compare Numbers', x=int(x), y=int(y))


if __name__ == '__main__':
    app.run()
