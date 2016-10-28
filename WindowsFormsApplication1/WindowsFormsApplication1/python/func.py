def isIn(d, key, info):
    for data in d[key]:
        if data == info:
            return 1
    return 0