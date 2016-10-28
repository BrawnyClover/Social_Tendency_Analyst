import json
import matplotlib.pyplot as plt
from matplotlib import font_manager, rc
from matplotlib import style
import func

font_name = font_manager.FontProperties(fname="c:/Windows/Fonts/malgun.ttf").get_name()
rc('font', family=font_name)
style.use('ggplot')

data = ''
classList = ''
with open('data.json',encoding="cp949") as f:
    data = f.read()

with open('classList.json',encoding="cp949")as g:
    info = g.read()

# str -> dictionary
classData = json.loads(data) # number
classInfo = json.loads(info) # category

# dict -> str
#s = json.dumps(d)
#print(s,type(s))

ratio = list()
labels = list()

#for key in d:
#    for infoKey in e:
#        if infoKey in d[key]:
#            ratio.append(d[key][0])
#            labels.append(key)
#plt.bar(ratio,labels=labels,height=10)
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
#plt.pie(ratio, labels=labels, shadow=True, startangle=90)
#plt.show()

