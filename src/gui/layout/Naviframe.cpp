/*
 * Naviframe.cpp
 *
 *  Created on: Mar 19, 2017
 *      Author: YJK
 */

#include "gui/layout/Naviframe.h"

using namespace std;

void Naviframe::HWbackBtn_callback(void *data, Evas_Object *obj, void *event_info)
{
	elm_naviframe_item_pop(obj);
}

Naviframe::Naviframe(UILayout parent){
	mContent = elm_naviframe_add(parent.getContent());
	elm_naviframe_prev_btn_auto_pushed_set(mContent, EINA_TRUE);

	eext_object_event_callback_add(mContent, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);

	evas_object_show(mContent);
}
NaviItem Naviframe::addItem(string title,Button prevBtn,Button nextBtn,RootObj obj,string itemStyle){
	Evas_Object * na_it;
	if(itemStyle.compare("") == 0)
		na_it = elm_naviframe_item_push(mContent, title.c_str(), prevBtn.getContent(), nextBtn.getContent(), obj.getContent(), NULL);
	else
		na_it = elm_naviframe_item_push(mContent, title.c_str(), prevBtn.getContent(), nextBtn.getContent(), obj.getContent(), itemStyle.c_str());
	return NaviItem(na_it);
}
void Naviframe::setAutoBackBtn(){
	elm_naviframe_prev_btn_auto_pushed_set(mContent,EINA_TRUE);
}
void Naviframe::unSetAutioBackBtn(){
	elm_naviframe_prev_btn_auto_pushed_set(mContent,EINA_FALSE);
}
void Naviframe::popItem(){
	elm_naviframe_item_pop(mContent);
}
Naviframe::~Naviframe(){

}
