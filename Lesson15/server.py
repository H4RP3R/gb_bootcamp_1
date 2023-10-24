import redis
from random import randint


with redis.Redis() as redis_server:
    redis_server.lpush('queue', randint(0, 10))
