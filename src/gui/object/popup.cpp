/*
 * popup.cpp
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */
#include <gui/object/popup.h>

UILayout* Popup::mMyWin = NULL;

void Popup::setPopWin(UILayout * parent){
	mMyWin = parent;
}

void Popup::callback_block_clicked(void *data, Evas_Object *obj, void *event_info)
{
	((Popup *)data)->block_clicked();
}
void Popup::callback_dismissed(void *data, Evas_Object *obj, void *event_info)
{
	((Popup *)data)->dismissed();
}
void Popup::callback_timeout(void *data, Evas_Object *obj, void *event_info)
{
	((Popup *)data)->timeout();
}

Popup::Popup()
{
	mContent = elm_popup_add(mMyWin->getContent());

	evas_object_show(mContent);

	eext_object_event_callback_add(mContent, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
	evas_object_smart_callback_add(mContent,"block,clicked",callback_block_clicked,this);
	evas_object_smart_callback_add(mContent,"dismissed",callback_dismissed,this);
	evas_object_smart_callback_add(mContent,"timeout",callback_timeout,this);
}
void Popup::setTimeout(double timeout)
{
	elm_popup_timeout_set(mContent, timeout);
}

void Popup:: block_clicked()
{
	elm_popup_dismiss(mContent);
}
void Popup::dismissed()
{
	evas_object_del(mContent);
}
void Popup::timeout()
{
	elm_popup_dismiss(mContent);
}


