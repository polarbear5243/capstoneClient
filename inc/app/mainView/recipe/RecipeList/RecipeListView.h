/*
 * MyRecipeShow.h
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

#include"RecipeListRecipeItem.h"

//#include"app/MyRecipeInfo.h"

class RecipeListView
{
	class BackBtn : public Button
	{
	private:
		Naviframe* mNaviframe;
	public:
		BackBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
			this->setText("뒤로가기");
			//setMinHint(0, 150);
			setMaxHint(600, 9999);
		}
		void click()
		{
			mNaviframe->popItem();
		}
	};
private:
	Background* mBg;
	Scroll* mScroll;
	Layout* mLayout;
	Box* mBox;
	List* mList;

	BackBtn* mBtnBack;
public:
	RecipeListView(Naviframe* parentNavi){
		drawUI(parentNavi);
	}
	void drawUI(Naviframe* parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("레시피 보기",nullBtn,nullBtn,*mBg,"").setTitleEnalble(TRUE, TRUE);

		mScroll = new Scroll(*mBg);
		elm_object_content_set(mBg->getContent(),mScroll->getContent());

		mLayout = new Layout(*mScroll);
		mLayout->setEDCfile("recipe_view_layout");
		mLayout->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_EXPAND);
		mScroll->add(*mLayout);

		mList = new List(*mLayout);
		for(int i=0; i<20; i++){
			ReceipeListRecipeList* items = new ReceipeListRecipeList("인도의 향기", parentNavi);
			mList->addItem((ListItem*)items);
		}
		mLayout->setContent("swallow_content", *mList);

		mBox = new Box(*mLayout);
		mLayout->setContent("swallow_buttons", *mBox);
		mBtnBack = new BackBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnBack);
	}
};
