/*
 * MyMainScroll.h
 *
 *  Created on: Apr 1, 2017
 *      Author: BGKG
 */

#pragma once
#include <app/AppSocket.h>
#include <app/mainView/food/foodMain/FoodMainView.h>
#include"gui/object/Label.h"
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/layout/NaviItem.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/Scroll.h"
#include"gui/layout/BackGround.h"
#include"gui/object/popup.h"
#include"gui/object/Toolbar.h"
#include "app/mainView/recipe/MyRecipeView.h"
#include <system_info.h>

#include<string>
	class MainScroller : public Scroll
	{
	private:
		UILayout mParent;
		Toolbar* mToolbar;
	public:
		MainScroller(UILayout parent, Toolbar* tb) : Scroll(parent) {
			mParent = parent;
			mToolbar = tb;
		}
		void anim_stop(){
			Elm_Object_Item *item;
			int index, page = 0;

			this->getCurrentPage(&page, NULL);

			item = mToolbar->getItemFirst();

			for (index = 0; index < page; index++)
				item = elm_toolbar_item_next_get(item);
			elm_toolbar_item_selected_set(item, EINA_TRUE);
		}
	};
	static MainScroller* dummy = NULL;
class MyMainScroll
{

private:
	string mMyEdj;

	Evas_Coord w, h;

	Background* mBg;
	Layout* mLayoutMain;
	Box* mBoxMain;
	Toolbar* mToolbar;
	MainScroller* mScroller;
	Box* mBoxofScroller;

	MyRecipeView* mRecipeView;
	FoodMainView * mFoodView;
public:
	MyMainScroll(Naviframe * parentNavi){
		mMyEdj = "login_layout";
		drawUI(parentNavi);
	}
static void call_food(void *data, Evas_Object *obj, void *event_info)
{
	if(dummy != NULL)
		elm_scroller_page_bring_in(dummy->getContent(), 0, 0);
}
static void call_recipe(void *data, Evas_Object *obj, void *event_info)
{
	if(dummy != NULL)
		elm_scroller_page_bring_in(dummy->getContent(), 1, 0);
}

protected:
	void drawUI(Naviframe* parentNavi)
	{
		mLayoutMain = new Layout(*parentNavi);
		mLayoutMain->setTheme("layout", "application", "default");
		Button nullBtn;
		parentNavi->addItem("MainScroll",nullBtn,nullBtn,*mLayoutMain,"tabbar/notitle").setTitleEnalble(FALSE, FALSE);


		mBg = new Background(*mLayoutMain);
		mBg->setColor(166,133,93);
		mLayoutMain->setContent("elm.swallow.bg", *mBg);


		mBoxMain = new Box(*mLayoutMain);
		mBoxMain->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mBoxMain->setAlignHint( EVAS_HINT_FILL, EVAS_HINT_FILL);
		mLayoutMain->setContent("elm.swallow.content", *mBoxMain);

		mToolbar = new Toolbar(*mBoxMain);

		mToolbar->setStyle("tabbar");
		mToolbar->setShrinkMode(ELM_TOOLBAR_SHRINK_EXPAND);
		mToolbar->setTransverseExpanded(EINA_TRUE);
		mToolbar->setSelectMode(ELM_OBJECT_SELECT_MODE_ALWAYS);
		mToolbar->appendItem(NULL, "tab1", call_food, NULL);
		mToolbar->appendItem(NULL, "tab2", call_recipe, NULL);
		mToolbar->appendItem(NULL, "tab3", call_food, NULL);
		mToolbar->setWeightHint(EVAS_HINT_EXPAND, 0);
		mToolbar->setAlignHint( EVAS_HINT_FILL, EVAS_HINT_FILL);
		mBoxMain->addBack(*mToolbar);

/*
		mPwLabel = new Label(*mBoxMain);
		mPwLabel->setAlignHint(0.05, EVAS_HINT_FILL);
		mPwLabel->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mPwLabel->setText("<b>Enter your password</b>");
		mBoxMain->addBack(*mPwLabel);
*/

		mScroller = new MainScroller(*mBoxMain, mToolbar);
		mScroller->setStyle("tabbar");
		dummy = mScroller;
		mScroller->setPolicy(ELM_SCROLLER_POLICY_ON, ELM_SCROLLER_POLICY_OFF);
		mScroller->setPageSize(0, 0);
		mScroller->setScrollLimit(1, 0);
		mScroller->setSingleDirection(ELM_SCROLLER_SINGLE_DIRECTION_HARD);
		mScroller->setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		mScroller->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mBoxMain->addBack(*mScroller);

		mBoxofScroller = new Box(*mScroller);
		mBoxofScroller->setHorizontal();
		elm_object_content_set(mScroller->getContent(), mBoxofScroller->getContent());

		parentNavi->getGeometry(NULL, NULL, &w, NULL);
		mScroller->getGeometry(NULL, NULL, NULL, &h);
		mScroller->setPageSize(w, h);

		mRecipeView = new MyRecipeView(mBoxofScroller, w, h);
	}
};
