/*
 * Toolbar.cpp
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */
#include <gui/object/Toolbar.h>

Toolbar::Toolbar(UILayout parent)
{
	mContent = elm_toolbar_add(parent.getContent());

	evas_object_show(mContent);
}
Elm_Object_Item* Toolbar::getItemFirst()
{
	return elm_toolbar_first_item_get(mContent);
}
void Toolbar::appendItem(const char *icon, const char *label, Evas_Smart_Cb func, const void *data)
{
	elm_toolbar_item_append(mContent, icon, label, func, data);
}
void Toolbar::setShrinkMode(Elm_Toolbar_Shrink_Mode shrink_mode)
{
	elm_toolbar_shrink_mode_set(mContent, shrink_mode);
}
void Toolbar::setTransverseExpanded(Eina_Bool transverse_expanded)
{
	elm_toolbar_transverse_expanded_set(mContent, transverse_expanded);
}
void Toolbar::setSelectMode(Elm_Object_Select_Mode mode)
{
	elm_toolbar_select_mode_set(mContent, mode);
}



