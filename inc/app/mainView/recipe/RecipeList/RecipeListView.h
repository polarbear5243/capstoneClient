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
#include"RecipeListRecipeList.h"
#include"RecipeListSearchButton.h"

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

	Entry * mSearchEntry;
	RecipeListSearchButton * mSearchButton;

	RecipeListRecipeList* mList;
	BackBtn* mBtnBack;
public:
	RecipeListView(Naviframe* parentNavi){
		mSearchEntry = NULL;
		mList = NULL;

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
		mScroll->add(*mLayout);

		mSearchEntry = new Entry(*parentNavi);
		mLayout->setContent("swallow_search_entry",*mSearchEntry);

		mList = new RecipeListRecipeList(*mLayout, parentNavi);
		mLayout->setContent("swallow_content", *mList);

		mSearchButton = new RecipeListSearchButton(*parentNavi,mSearchEntry, mList);
		mLayout->setContent("swallow_search_button", *mSearchButton);

		mBox = new Box(*mLayout);
		mLayout->setContent("swallow_buttons", *mBox);
		mBtnBack = new BackBtn(*mBox, parentNavi);
		mBox->addBack(*mBtnBack);
	}
};
