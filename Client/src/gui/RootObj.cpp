/*
 * RootObj.cpp
 *
 *  Created on: Mar 16, 2017
 *      Author: YJK
 */

#include <gui/RootObj.h>
#include <string>

RootObj::RootObj() {
	mContent=NULL;
	// TODO Auto-generated constructor stub

}

RootObj::~RootObj() {
	// TODO Auto-generated destructor stub
}

Evas_Object * RootObj::getContent(){
	return mContent;
}

void RootObj::setWeightHint(float width, float height){
	evas_object_size_hint_weight_set(mContent,width,height);
}

void RootObj::setAlignHint(float width, float height){
	evas_object_size_hint_align_set(mContent,width,height);
}
void RootObj::setMinHint(float width, float height){
	evas_object_size_hint_min_set(mContent,width,height);
}
void RootObj::setMaxHint(float width, float height){
	evas_object_size_hint_max_set(mContent,width,height);
}
void RootObj::show(){
	evas_object_show(mContent);
}
void RootObj::setEnable(){
	elm_object_disabled_set(mContent, EINA_FALSE);
}
void RootObj::setDisable(){
	elm_object_disabled_set(mContent, EINA_TRUE);
}
void RootObj::addCallback(Evas_Callback_Type type, Evas_Object_Event_Cb func, const void *data) EINA_ARG_NONNULL(1, 3)
{
	evas_object_event_callback_add(mContent, type, func, data)EINA_ARG_NONNULL(1, 3);
}
void RootObj::setContent(std::string part, RootObj obj)
{
	elm_object_part_content_set(mContent, part.c_str(), obj.getContent());
}
void RootObj::setStyle(std::string style)
{
	elm_object_style_set(mContent, style.c_str());
}
