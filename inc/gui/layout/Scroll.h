/*
 * Scroll.h
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */
#pragma once
#include <gui/layout/UILayout.h>

class Scroll:public UILayout{
public:
	static const int DEFAULT_STYLE;
	static const int HANDLER_STYLE;

public:
	Scroll(UILayout parent);
	virtual ~Scroll();
	void add(RootObj obj);
	void setStyle(int style);
};

//스크롤 위치 지정??? 알아봐야할듯
//elm_scroller_page_bring_in(ad->scroller, 0, 0);
