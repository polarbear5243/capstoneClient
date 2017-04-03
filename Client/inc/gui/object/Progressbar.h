/*
 * Progressbar.h
 *
 *  Created on: Mar 31, 2017
 *      Author: BGKG
 */

#ifndef GUI_OBJECT_PROGRESSBAR_H_
#define GUI_OBJECT_PROGRESSBAR_H_

#include <gui/layout/UILayout.h>
#include"Object.h"

class Progressbar : public Object
{
public:
	Progressbar(UILayout parent);
	void setPulse(Eina_Bool state);
	void setAnimation(Eina_Bool state);
	void setValue(double val);
};



#endif /* GUI_OBJECT_PROGRESSBAR_H_ */
