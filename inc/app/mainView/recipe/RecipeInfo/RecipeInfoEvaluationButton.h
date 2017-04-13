#pragma once
#include"gui/object/Button.h"
#include"gui/object/Entry.h"

#include"app/DataModel/UserInfo.h"
#include"RecipeInfoSocket.h"

#include<string>
#include<vector>

using namespace std;

class RecipeInfoEvaluationButton : public Button{
protected:
	Entry * mEntry;
	string mRecipeId;
public:
	RecipeInfoEvaluationButton(UILayout parent, Entry * entry, string recipeId):Button(parent){
		mEntry = entry;
		mRecipeId = recipeId;
		this->setText("평가");
	}

	void click(){
		UserInfo * user = UserInfo::getInstance();
		string userId = user->getMyId();

		RecipeInfoSocket * socket = new RecipeInfoSocket();

		int score = atoi(mEntry->getText().c_str());
		if(score >= 10)
			score = 10;
		if(score <= 0)
			score = 0;

		vector<string> result = socket->evaluation(userId,mRecipeId,score);

		if(result.at(0).compare("Success")==0){
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "평가 완료");
			toast->setTimeout(2.0);
		}
		delete socket;
	}
};
