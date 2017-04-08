#include <app/DataModel/UserInfo.h>
#include <app/mainView/food/foodMain/FoodMainView.h>
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

		LodingSocket socket;

		vector<string> userData = socket.getMyIngredient(userID);

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

		Popup* toast = new Popup();
		toast->setStyle("toast");
		elm_object_text_set(toast->getContent(), "초기화 완료");
		toast->setTimeout(2.0);

		new FoodMainView(parent);

	}
};
