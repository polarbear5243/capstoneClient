/*
 * Gengrid.cpp
 *
 *  Created on: Apr 3, 2017
 *      Author: BGKG
 */
#include "gui/object/Gengrid.h"
void Gengrid::callback_pressed(void *data, Evas_Object *obj, void *event_info)
{
	((Gengrid *)data)->pressed();
}

Gengrid::Gengrid(UILayout parent)
{
	mContent = elm_gengrid_add(parent.getContent());
	//itc = elm_gengrid_item_class_new();
	evas_object_show(mContent);
	evas_object_smart_callback_add(mContent,"pressed",callback_pressed,this);
}
void Gengrid::setItemSize(Evas_Coord w, Evas_Coord h)
{
	elm_gengrid_item_size_set(mContent, w, h);
}
void Gengrid::setAlign(double align_x, double align_y)
{
	elm_gengrid_align_set(mContent, 0.5, 0.5);
}
void Gengrid::setHorizontal(Eina_Bool horizontal)
{
	elm_gengrid_horizontal_set(mContent, horizontal);
}
void Gengrid::setMultiSelect(Eina_Bool multi)
{
	elm_gengrid_multi_select_set(mContent, multi);
}


void Gengrid::pressed()
{
	dlog_print(DLOG_INFO, "MY_LOG", "Item pressed\n");
}


