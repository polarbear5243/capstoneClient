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

#include "RecommendButton.h"
#include "RecommendPreferHoversel.h"
#include "RecommendSocket.h"
#include "RecommendFactor.h"

#include <vector>
#include <string>

using namespace std;

class RecommendView
{
private:
	RecommendFactor* factor;
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;

	Scroll* mEntryScroll;
	Entry * mEntryRecommend;
	Label* mLabelPrefer;
	RecommendButton* mBtnRecommend;
	RecommendPreferHoversel* mHoverselPrefer;

public:
	RecommendView(Naviframe* parentNavi){
		factor = new RecommendFactor();
		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("추천",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setEDCfile("recommend_view");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mEntryScroll = new Scroll(*mLayout);
		mLayout->setContent("recommend_entry",*mEntryScroll);


		mEntryRecommend = new Entry(*mEntryScroll);
		mEntryRecommend->setMultLine();
		writeRecommendnfo();
		mEntryRecommend->setDisable();
		mEntryScroll->add(*mEntryRecommend);

		mLabelPrefer = new Label(*mLayout);
		mLabelPrefer->setText("최우선 추천 요소");
		mLayout->setContent("prefer_hoversel",*mLabelPrefer);

		mHoverselPrefer = new RecommendPreferHoversel(*mLayout, factor);
		mLayout->setContent("prefer_label",*mHoverselPrefer);

		mBtnRecommend = new RecommendButton(*mLayout, mHoverselPrefer);
		mLayout->setContent("recommend_button",*mBtnRecommend);

	}
protected:
	void writeRecommendnfo(){
		//mEntryRecommend->setEnable();
		//RecommendSocket * socket = new RecommendSocket();

	}
};
