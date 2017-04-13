/*
 * MyRecipeInfo.h
 *
 *  Created on: Apr 5, 2017
 *      Author: BGKG
 */

#pragma once
#include"gui/object/Label.h"
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/layout/Scroll.h"
#include"gui/object/List.h"
#include"gui/object/ListItem.h"

#include"RecipeInfoEvaluationButton.h"
#include"RecipeInfoBackButton.h"
#include"RecipeInfoFeedbackButton.h"
#include"RecipeInfoSocket.h"

#include <vector>
#include <string>

using namespace std;

class RecipeInfoView
{
private:
	string mRecipeId;

	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;

	Scroll* mEntryScroll;
	Entry * mEntryRecipeInfo;

	Entry * mEntryEvaluation;
	RecipeInfoEvaluationButton* mBtnEvaluation;

	RecipeInfoFeedbackButton* mBtnFeedBack;
	RecipeInfoBackButton* mBtnBack;

public:
	RecipeInfoView(Naviframe* parentNavi, string recipeId){
		mRecipeId = recipeId;

		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("레시피 이름",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		mScroll->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mBg->add(*mScroll);

		mLayout = new Layout(*mScroll);
		mLayout->setEDCfile("recipe_info_layout");
		mLayout->setWeightHint(EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mEntryScroll = new Scroll(*mLayout);
		mLayout->setContent("swallow_info_entry",*mEntryScroll);


		mEntryRecipeInfo = new Entry(*mEntryScroll);
		mEntryRecipeInfo->setMultLine();
		writeRecipeInfo();
		mEntryRecipeInfo->setDisable();
		mEntryScroll->add(*mEntryRecipeInfo);

		mEntryEvaluation = new Entry(*mLayout);
		mLayout->setContent("swallow_evaluation_entry",*mEntryEvaluation);
		mBtnEvaluation = new RecipeInfoEvaluationButton(*mLayout,mEntryEvaluation,mRecipeId);
		mLayout->setContent("swallow_evaluation_button",*mBtnEvaluation);

		mBtnFeedBack = new RecipeInfoFeedbackButton(*mLayout);
		mLayout->setContent("swallow_feedback_button",*mBtnFeedBack);

		mBtnBack = new RecipeInfoBackButton(*mLayout,parentNavi);
		mLayout->setContent("swallow_back_button",*mBtnBack);

	}
protected:
	void writeRecipeInfo(){
		mEntryRecipeInfo->setEnable();
		RecipeInfoSocket * socket = new RecipeInfoSocket();

		vector<string> msg = socket->getRecipe(mRecipeId);
		string info = "";

		int i=0;
		info = info + "ID      :  " + msg[i++] + "<br/>";
		info = info + "이름        :  " + msg[i++] + "<br/>";
		info = info + "나라        :  " + msg[i++] + "<br/>";
		info = info + "분류        :  " + msg[i++] + "<br/>";
		info = info + "시간(분) :  " + msg[i++] + "<br/>";
		info = info + "열량        :  " + msg[i++] + "<br/>";
		info = info + "난이도     :  " + msg[i++] + "<br/>";
		info = info + "재료" + "<br/>";
		while(msg[i] != "End"){
			info = info + msg[i] + ", ";
			i++;
		}
		i++;

		info = info + "<br/>" + "조리법" + "<br/>";

		int start_i = i;
		while(msg[i] != "End"){

			char index[20];
			sprintf(index,"%d",i-start_i+1);

			info = info + index + ". " + msg[i] + "<br/>";
			i++;
		}

		mEntryRecipeInfo->setText(info);
	}
};
