/*
 * Button.cpp
 *
 *  Created on: Mar 20, 2017
 *      Author: YJK
 */
#include<gui/object/Button.h>

void Button::callback_click(void *data, Evas_Object *obj, void *event_info){
	((Button *)data)->click();
}
void Button::callback_pressed(void *data, Evas_Object *obj, void *event_info){
	((Button *)data)->pressed();
}
void Button::callback_unpressed(void *data, Evas_Object *obj, void *event_info){
	((Button *)data)->unpressed();
}
Button::Button(){
	mContent=NULL;
}
Button::Button(UILayout parent){
	mContent = elm_button_add(parent.getContent());
//	setWeightHint(EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	setAlignHint(EVAS_HINT_FILL, 0.5);

	setMaxHint(300,300);
	setMinHint(300,300);

	evas_object_show(mContent);

	evas_object_smart_callback_add(mContent,"clicked",callback_click,this);
	evas_object_smart_callback_add(mContent,"pressed",callback_pressed,this);
	evas_object_smart_callback_add(mContent,"unpressed",callback_unpressed,this);
}
void Button::setText(string str){
	mTextStyle.setText(str);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
void Button::setAlign(string align){
	mTextStyle.setText(align);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}
void Button::setColor(string color){
	mTextStyle.setText(color);
	elm_object_text_set(mContent,mTextStyle.getStyleText().c_str());
}

void Button::setStyle(string str){
	elm_object_style_set(mContent,str.c_str());
}
void Button::click(){
	dlog_print(DLOG_INFO, "MY_LOG", "Button clicked\n");
}
void Button::pressed(){
	dlog_print(DLOG_INFO, "MY_LOG", "Button pressed\n");
}
void Button::unpressed(){
	dlog_print(DLOG_INFO, "MY_LOG", "Button unpressed\n");
}
