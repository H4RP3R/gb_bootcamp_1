class User:
    def __init__(self, username, email, password):
        self.username = username
        self.email = email
        self.password = password

    def __str__(self):
        return f'<User: {self.username}>'


def read_users():
    '''
    Reads "db.txt" and returns a dictionary with all users.
    '''
    users = {}
    with open('db.txt', 'r') as f:
        for line in f.readlines():
            username, email, password = line.strip().split(';')
            users[username] = {
                'email': email,
                'password': password,
            }
        return users


def get_user(username, password):
    '''
    Returns "User" instance if a user with specified username and password exists. Otherwise return None.
    '''
    users = read_users()
    user = users.get(username)
    if user and user['password'] == password:
        return User(username=username, email=user['email'], password=user['password'])
    return None
