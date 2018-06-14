import sqlite3
import datetime
import csv

connection = sqlite3.connect('C:\Users\danijels\Desktop\ActivitiesCache.db')
c = connection.cursor()
def AppID (app):
    kot = chr(34)
    dd = chr(58)
    converter =  str(app)
    appIdSplit = converter.split(',')
    appIdEd = appIdSplit[2].lstrip('{')
    appN = appIdEd.split(kot+dd+kot)
    return str(appN[1].rstrip('"'))

def date_converter(epoch):
    datum = str(datetime.datetime.fromtimestamp(int(epoch)).strftime('%c'))
    return datum

# Open cdv file
with open('timeline.csv', 'wb')as csvfile:
    fieldnames = ['App ID', 'File opend','Program used to open file', 'Path to file', 'Last modified time','Esxpiration time', 'Last modified on client', 'Start time', 'End time']
    writer = csv.DictWriter(csvfile, fieldnames=fieldnames,extrasaction='ignore' ,delimiter = ';')
    writer.writeheader()

# TXT file
datoteka = open("dat.txt","w")


#Data stores in Activity table

for row in c.execute('SELECT AppId,LastModifiedTime,ExpirationTime,Payload,StartTime,EndTime,LastModifiedOnClient FROM Activity'):

    appId = row[0]
    lastModifiedTime = row[1]
    expirationTime = row[2]
    payload = row[3]
    startTime = row[4]
    endtime = row[5]
    lastModifiedOnClient = row[6]

# parsanje aplikacije koja je bila pokrenuta iz stupca AppID
    #AppID(appId)

#lastModifiedTime pretvaranje u real time
    #date_converter(lastModifiedTime)
    #date_converter(expirationTime)
    #date_converter(startTime)
    #date_converter(lastModifiedOnClient)
    #date_converter(endtime)

# editing payoad output
    payloadEd = str(payload).split(",")

    payloadF = payloadEd[0].split(":")
    payloadA = payloadEd[2].split(":")
    payloadP = payloadEd[3]
    #print payloadF, payloadA, payloadP
    #print payloadP
# file that was opend
    if "displayText" not in payloadF[0]:
        payloadFile = " "
    else:
        payloadFile = str(payloadF[1].strip('"'))
# application used to open file
    try:
        if "appDisplayName" in payloadA[0]:
            payloadApp = str(payloadA[1].strip('"'))
        else:
            payloadApp = " "
    except Exception:
        print " "

# path to file executed
    if "description" not in payloadP:
        payloadPath = "none"
    else:
        payloadPath = str(payloadP)

    aplicationID = AppID(appId)
    file = payloadFile
    program = payloadApp
    putanja = payloadPath
    modify = date_converter(lastModifiedTime)
    expire = date_converter(expirationTime)
    client = date_converter(lastModifiedOnClient)
    start = date_converter(startTime)
    end = date_converter(endtime)

    datoteka.write("FIle opend: "+file+'\n')
    datoteka.write("Program used: "+program+'\n')
    datoteka.write("path to file: "+putanja+'\n')
    datoteka.write("Last modified: "+modify+'\n')
    datoteka.write("Expired: "+expire+'\n')
    datoteka.write("Last modified on client: "+client+'\n')
    datoteka.write("Start time: "+start+'\n')
    datoteka.write("End time: "+end+'\n')
    datoteka.write("-----------------------------------------------------------------------------------------------------"+'\n')



datoteka.close()
csvfile.close()