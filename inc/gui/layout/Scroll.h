/*
 * Scroll.h
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */
#pragma once
#include <gui/layout/UILayout.h>

class Scroll:public UILayout{
private:
	static void callback_anim_stop(void *data, Evas_Object *obj, void *event_info);

public:
	static const int DEFAULT_STYLE;
	static const int HANDLER_STYLE;

public:
	Scroll(UILayout parent);
	virtual ~Scroll();
	void add(RootObj obj);
	void getCurrentPage(int* h_pagenumber, int *v_pagenumber);
	//void setStyle(int style);
	void setLoop(Eina_Bool loop_h, Eina_Bool loop_v);
	void setPageRelationVal(double h_pagerel, double v_pagerel);
	void setPageSize(Evas_Coord h_pagesize, Evas_Coord v_pagesize);
	void setPolicy(Elm_Scroller_Policy policy_h, Elm_Scroller_Policy policy_v);
	void setScrollLimit(int page_limit_h, int page_limit_v);
	void setLockYaxis(Eina_Bool lock);
	void setSingleDirection(Elm_Scroller_Single_Direction single_dir);
protected:
	virtual void anim_stop();
};

//스크롤 위치 지정??? 알아봐야할듯
//elm_scroller_page_bring_in(ad->scroller, 0, 0);
