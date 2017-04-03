/*
 * Scroll.cpp
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */

#include "gui/layout/Scroll.h"

const int Scroll::DEFAULT_STYLE = 0;
const int Scroll::HANDLER_STYLE = 1;

Scroll::Scroll(UILayout parent){
	mContent = elm_scroller_add(parent.getContent());
	evas_object_show(mContent);
}
Scroll::~Scroll(){
}
void Scroll::add(RootObj obj){
	elm_object_content_set(mContent,obj.getContent());
}
void Scroll::setStyle(int style){
	if(style==1)
		elm_object_style_set(mContent,"handler");
	else
		elm_object_style_set(mContent,"default");
}
