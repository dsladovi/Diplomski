# creating a code to export all saved accaspoint passwords to a txt file

import os
#korstenje CMD-a kako bi ispisali sve acces pointove koji su spremljeni

def deleteContent(pfile):
    with open(pfile,"w"):
        pass
def search_for_password(datoteka,text):
    print '>>>>>>>>>>>>>>>>>>WLAN Acces Points Saved>>>>>>>>>>>>>>>>>>>>>'
    for redak in datoteka.readlines():
        if text in redak:
            useriRaw = redak.split(":")
            imena=str(useriRaw[1]).lstrip().rstrip()
            print imena
            # sad trazit pass za svakog nadenog usera
            os.popen('netsh wlan show profiles name="'+imena+'" key=clear >> C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\Credentials2.txt')
    print '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>'
def edit_rez(user,password):
    brojac2=1
    rezultati = open("C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\Credentials2.txt", "r")
    for retci in rezultati.readlines():
        if user in retci:
            print retci
            userAndPass.write(str(brojac2)+'\n')
            userAndPass.write(retci)
        if password in retci:
            print retci
            brojac2=brojac2+1
            userAndPass.write(retci+'\n')

    print "<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<"
    rezultati.close()

os.popen("netsh wlan show profiles > C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\Profili.txt")


profili=open("C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\Profili.txt", "r")

userAndPass=open("C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\userIpass.txt", "w")

useriRaw= []
nameRaw = []
passoviRaw = []

traziUser= "All User Profile"
traziName= "Name"
traziKey= "Key Content"


deleteContent("C:\Users\gslad\Documents\GitHub\Diplomski\Rezultati\WifiPassUser\Credentials2.txt")
search_for_password(profili,traziUser)
edit_rez(traziName,traziKey)

os.system("pause")

profili.close()
userAndPass.close()

