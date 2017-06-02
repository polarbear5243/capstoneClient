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
#include "RecommendList.h"

#include <vector>
#include <string>

using namespace std;

class RecommendView
{
private:
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;

	Scroll* mEntryScroll;
	RecommendList* mList;
	Label* mLabelPrefer1;
	Label* mLabelPrefer2;
	Label* mLabelPrefer3;
	Label* mLabelPrefer4;
	RecommendButton* mBtnRecommend;
	RecommendPreferHoversel* mHoverselPrefer1;
	RecommendPreferHoversel* mHoverselPrefer2;
	RecommendPreferHoversel* mHoverselPrefer3;
	RecommendPreferHoversel* mHoverselPrefer4;

public:
	RecommendView(Naviframe* parentNavi){
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
		mLayout->setEDCfile("recipe_recommend");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mEntryScroll = new Scroll(*mLayout);
		mLayout->setContent("recommend_entry",*mEntryScroll);
		mEntryScroll->setSingleDirection(ELM_SCROLLER_SINGLE_DIRECTION_HARD);


		mList = new RecommendList(*mEntryScroll, parentNavi);

/*		RecipeItem* items1 = new RecipeItem("돌솔비빔밥", parentNavi);
		mList->addItem((ListItem*)items1);

		RecipeItem* items2 = new RecipeItem("나물비빔밥", parentNavi);
		mList->addItem((ListItem*)items2);
		RecipeItem* items3 = new RecipeItem("버섯 크림 리조또", parentNavi);
		mList->addItem((ListItem*)items3);*/

		mLayout->setContent("swallow_content", *mList);


		mEntryScroll->add(*mList);

		mLabelPrefer1 = new Label(*mLayout);
		mLabelPrefer1->setText("1순위");
		mLayout->setContent("prefer_label1",*mLabelPrefer1);
		mLabelPrefer2 = new Label(*mLayout);
		mLabelPrefer2->setText("2순위");
		mLayout->setContent("prefer_label2",*mLabelPrefer2);
		mLabelPrefer3 = new Label(*mLayout);
		mLabelPrefer3->setText("3순위");
		mLayout->setContent("prefer_label3",*mLabelPrefer3);
		mLabelPrefer4 = new Label(*mLayout);
		mLabelPrefer4->setText("4순위");
		mLayout->setContent("prefer_label4",*mLabelPrefer4);

		mHoverselPrefer1 = new RecommendPreferHoversel(*mLayout, parentNavi->getContent(), "식재료");
		mLayout->setContent("prefer_hoversel1",*mHoverselPrefer1);

		mHoverselPrefer2 = new RecommendPreferHoversel(*mLayout, parentNavi->getContent(), "맛");
		mLayout->setContent("prefer_hoversel2",*mHoverselPrefer2);

		mHoverselPrefer3 = new RecommendPreferHoversel(*mLayout, parentNavi->getContent(), "나라");
		mLayout->setContent("prefer_hoversel3",*mHoverselPrefer3);

		mHoverselPrefer4 = new RecommendPreferHoversel(*mLayout, parentNavi->getContent(), "카테고리");
		mLayout->setContent("prefer_hoversel4",*mHoverselPrefer4);

		mBtnRecommend = new RecommendButton(*mLayout, mHoverselPrefer1, mHoverselPrefer2, mHoverselPrefer3, mHoverselPrefer4, mList);
		mLayout->setContent("recommend_button",*mBtnRecommend);

	}
};
