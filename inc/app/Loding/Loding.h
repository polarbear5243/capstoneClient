#include <app/DataModel/UserInfo.h>
#include <app/mainView/MainViewl.h>
#include"app/AppSocket.h"
#include"app/AppParser.h"

#include"gui/layout/Naviframe.h"
#include"LodingSocket.h"

#include<string>

using namespace std;

class Loding{
public:
	Loding(Naviframe * parent, string userID){
		UserInfo::init(userID);
		UserInfo * userInfo = UserInfo::getInstance();

		LodingSocket * socket = new LodingSocket();

		vector<string> userData = socket->getMyIngredient(userID);

		int i=1;
		string id;
		string name;
		while(true){
			id = userData.at(i);
			if(id.compare("End") == 0)
				break;
			name = userData.at(i+1);
			userInfo->addGroceries(id,name);
			i+=2;
		}

		delete socket;
		new MainViewl(parent);

	}
};
