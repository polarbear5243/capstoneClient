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

#include"SurveyButton.h"
#include"SurveyEntry.h"

#include <vector>
#include <string>

using namespace std;

class SurveyView
{
private:
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;

	Scroll* mEntryScroll;
	SurveyEntry * mEntrySurvey;
	SurveyDislikeButton* mBtnDislike;
	SurveyLikeButton* mBtnLike;

public:
	SurveyView(Naviframe* parentNavi){
		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		NaviItem naviItem =	parentNavi->addItem("사전조사",nullBtn,nullBtn,*mBg,"");
		naviItem.setTitleEnalble(TRUE, TRUE);
		naviItem.setFinalNavi();

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setEDCfile("init_survey_view");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mEntryScroll = new Scroll(*mLayout);
		mLayout->setContent("survey_entry",*mEntryScroll);

		mEntrySurvey = new SurveyEntry(*mEntryScroll);
		mEntryScroll->add(*mEntrySurvey);

		mBtnLike = new SurveyLikeButton(*mLayout,mEntrySurvey->getRecipeId(),parentNavi,mEntrySurvey);
		mLayout->setContent("like_button",*mBtnLike);

		mBtnDislike = new SurveyDislikeButton(*mLayout,mEntrySurvey->getRecipeId(),parentNavi,mEntrySurvey);
		mLayout->setContent("dislike_button",*mBtnDislike);
	}
};

