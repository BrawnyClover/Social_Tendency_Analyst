import json
import os

data = ''
classList = ''
path = os.path.dirname(os.path.abspath("classList.json"))

with open(path+'\\python\\data.json', encoding="utf-8-sig") as f:
    data = f.read()

with open(path+'\\python\\classList.json', encoding="utf-8-sig")as g:
    info = g.read()

classData = json.loads(data) # number
classInfo = json.loads(info) # category


ratio = list()
labels = list()

classDict = dict()
for key in classInfo:
    classDict[key] = 0

print(classInfo)
print(classData)
flag = False
for data in classData:
    for key in classInfo:
        for info in classInfo[key]:
            if data == info:
                classDict[key] += classData[data][0]
                flag = True
    if flag == False:
        classDict[data] = classDict.get(data, classData[data][0])
        print(classDict.keys())
    else : flag = False

print(classDict.keys())
f = open("result.json",'w',encoding='utf-8')
f.write("{\n");
for key in classDict:
    labels.append("["+key+"]")
    ratio.append(classDict[key])
    f.write('"'+key+'":[')
    f.write(str(classDict[key]))
    f.write('],\n')
f.write("}")
