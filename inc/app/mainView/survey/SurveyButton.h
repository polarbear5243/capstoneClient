#pragma once
#include"gui/object/Button.h"
#include"gui/layout/Naviframe.h"
#include<string>

#include"SurveyEntry.h"

using namespace std;

class SurveyLikeButton : public Button{
protected:
	Naviframe * mNavi;
	SurveyEntry * mSurveyEntry;
public:
	SurveyLikeButton(UILayout parent, string id, Naviframe * navi, SurveyEntry * surveyEntry):Button(parent){
		this->setText("좋아요");
		mNavi=navi;
		mSurveyEntry = surveyEntry;
	}

	void click(){
		UserInfo * user = UserInfo::getInstance();
		string userId = user->getMyId();

		RecipeInfoSocket * socket = new RecipeInfoSocket();

		vector<string> result = socket->evaluation(userId,mSurveyEntry->getRecipeId(),10);

		if(result.at(0).compare("Success")==0){
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "평가 완료");
			toast->setTimeout(2.0);
		}
		delete socket;

		if(mSurveyEntry->getCounter() <= 1)
			new MainViewl(mNavi);
		else
			mSurveyEntry->setEntry();
	}
};

class SurveyDislikeButton : public Button{
protected:
	Naviframe * mNavi;
	SurveyEntry * mSurveyEntry;
public:
	SurveyDislikeButton(UILayout parent, string id, Naviframe * navi, SurveyEntry * surveyEntry):Button(parent){
		this->setText("싫어요");
		mNavi=navi;
		mSurveyEntry = surveyEntry;
	}

	void click(){
		UserInfo * user = UserInfo::getInstance();
		string userId = user->getMyId();

		RecipeInfoSocket * socket = new RecipeInfoSocket();

		vector<string> result = socket->evaluation(userId,mSurveyEntry->getRecipeId(),0);

		if(result.at(0).compare("Success")==0){
			Popup* toast = new Popup();
			toast->setStyle("toast");
			elm_object_text_set(toast->getContent(), "평가 완료");
			toast->setTimeout(2.0);
		}
		delete socket;

		if(mSurveyEntry->getCounter() <= 1)
			new MainViewl(mNavi);
		else
			mSurveyEntry->setEntry();
	}
};
