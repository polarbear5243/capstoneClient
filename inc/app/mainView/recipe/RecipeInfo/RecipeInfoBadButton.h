#pragma once
#include"gui/object/Button.h"
#include"gui/object/Entry.h"

#include"app/DataModel/UserInfo.h"
#include"RecipeInfoSocket.h"

#include<string>
#include<vector>

using namespace std;

class RecipeInfoBadButton : public Button{
protected:
	string mRecipeId;
public:
	RecipeInfoBadButton(UILayout parent, string recipeId):Button(parent){
		mRecipeId = recipeId;
		this->setText("싫어요");
	}

	void click(){
		UserInfo * user = UserInfo::getInstance();
		string userId = user->getMyId();

		RecipeInfoSocket * socket = new RecipeInfoSocket();

		vector<string> result = socket->evaluation(userId,mRecipeId,0);

		if(result.at(0).compare("Success")==0){
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "평가 완료");
			toast->setTimeout(2.0);
		}
		delete socket;
	}
};
