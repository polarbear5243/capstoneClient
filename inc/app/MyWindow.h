/*
 * MyWindow.h
 *
 *  Created on: Mar 15, 2017
 *      Author: 제경
 */

#pragma once
#include"gui/Window.h"
#include"gui/object/Label.h"
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/object/popup.h"
#include"app/loginView/MyLogin.h"

class MyWindow : public Window
{
private:
	Conformant * mCoformant;
	Naviframe * mNaviframe;
	MyLogin * mMyLogin;

	void app_get_resource(const char *res_file_in, char *res_file_out, int path_max);
protected:
	void onCreate(){
		Popup::setPopWin(this);
		Layout::initEdcFile("app_view.edj");

		mCoformant = new Conformant(*this);
		mNaviframe = new Naviframe(*mCoformant);
		mCoformant->add(*mNaviframe);

		mMyLogin = new MyLogin(mNaviframe);

	}

	void app_terminate(void *data){
		Window::app_terminate(data);

		delete mCoformant;
		delete mNaviframe;
		delete mMyLogin;
	}
};
