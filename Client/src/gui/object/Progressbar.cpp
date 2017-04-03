/*
 * Progressbar.cpp
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */
#include <gui/object/Progressbar.h>

Progressbar::Progressbar(UILayout parent)
{
	mContent = elm_progressbar_add(parent.getContent());
	evas_object_show(mContent);
}
void Progressbar::setPulse(Eina_Bool state)
{
	elm_progressbar_pulse_set(mContent, state);
}
void Progressbar::setAnimation(Eina_Bool state)
{
	elm_progressbar_pulse(mContent, state);
}
void Progressbar::setValue(double val)
{
	elm_progressbar_value_set(mContent, val);
}


