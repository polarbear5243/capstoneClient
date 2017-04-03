/*
 * Conformant.cpp
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */
#pragma once
#include"gui/layout/Conformant.h"

Conformant::Conformant(Window win) {
	mContent = elm_conformant_add(win.getContent());
	evas_object_size_hint_weight_set(mContent,EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
	elm_win_resize_object_add(win.getContent(),mContent);
	evas_object_show(mContent);
}

Conformant::~Conformant() {

}

void Conformant::add(RootObj obj){
	elm_object_content_set(mContent, obj.getContent());
}
