from flask import Flask


app = Flask(__name__)


@app.route('/', methods=['get'])
def main():
    return '<h1>Howdy folks!</h1>'\
        '<a href="/info"/>About me</a>'


@app.route('/info', methods=['get'])
def info():
    return '<p>Info page</p>'\
        '<a href="/">back</a>'


@app.route('/sum/<x>/<y>')
def summ(x, y):
    return f'{x} + {y} = {int(x) + int(y)}'


if __name__ == '__main__':
    app.run()
