/*
 * MyWindow.h
 *
 *  Created on: Mar 15, 2017
 *      Author: 제경
 */

#pragma once
#include <app/AppSocket.h>
#include <app/fileIO/FileInput.h>
#include <app/fileIO/FileIO.h>
#include <app/fileIO/FileOutput.h>
#include <app/mainView/MainViewl.h>
#include "app/loginView/registerView/myRegister.h"

#include "app/Loding/Loding.h"

#include "gui/object/Label.h"
#include "gui/layout/Box.h"
#include "gui/layout/Conformant.h"
#include "gui/layout/Naviframe.h"
#include "gui/object/Entry.h"
#include "gui/layout/Layout.h"
#include "gui/layout/BackGround.h"
#include "gui/object/popup.h"
#include <fstream>
#include <system_info.h>

#include<string>
#include<vector>

using namespace std;

class MyLogin
{
	private:
	static const string LOGIN_FILE_NAME;

	class LoginSocket{
	protected:
		AppSocket * mSocket;
	public:
		LoginSocket(){
			mSocket = new AppSocket();
		}
		vector<string> autoLogin(string id, string pw, string deviceID){
			vector<string> msg;
			msg.push_back("Login");
			msg.push_back("Auto");
			msg.push_back(id);
			msg.push_back(pw);
			msg.push_back(deviceID);

			mSocket->sendData(AppParser::wrapMsg(msg));
			msg = AppParser::parsingMsg(mSocket->receiveData());

			return msg;
		}
		vector<string> manulLogin(string id, string pw, string deviceID){
			vector<string> msg;
			msg.push_back("Login");
			msg.push_back("Manual");
			msg.push_back(id);
			msg.push_back(pw);
			msg.push_back(deviceID);

			mSocket->sendData(AppParser::wrapMsg(msg));
			msg = AppParser::parsingMsg(mSocket->receiveData());

			return msg;
		}
		~LoginSocket(){
			delete mSocket;
		}

	};
	class LoginBtn : public Button
	{
	private:
		UILayout mParent;
		Entry * mLoginEntry;
		Entry * mPWEntry;
		LoginSocket * mySocket;
		Naviframe * mNaviframe;
		NaviItem * mNaviItem;
	public:
		LoginBtn(UILayout parent,Naviframe * naviFrame ,NaviItem * naviItem, Entry * loginEntry, Entry * pwEntry) : Button(parent) {
			mParent = parent;
			mLoginEntry = loginEntry;
			mPWEntry = pwEntry;
			mNaviframe = naviFrame;
			mNaviItem = naviItem;
		}
		void click()
		{
			try {
				mySocket = new LoginSocket();

				char * tempStr = NULL;
				system_info_get_platform_string("http://tizen.org/system/tizenid",&tempStr);
				string deviceid = tempStr;

				string id = mLoginEntry->getText();
				string pw = mPWEntry->getText();

				vector<string> result = mySocket->manulLogin(id,pw,deviceid);

				if(result.at(0).compare("Success") == 0)
				{
					Popup* toast = new Popup();
					toast->setStyle("toast");
					elm_object_text_set(toast->getContent(), "Success to login");
					toast->setTimeout(2.0);

					FileOutput output(LOGIN_FILE_NAME);
					output.writeln(mLoginEntry->getText().c_str());
					output.writeln(mPWEntry->getText().c_str());
					output.close();

					mNaviItem->unSetFinalNavi();
					mNaviframe->popItem();

					Loding * loding = new Loding(mNaviframe,id);
				}
				else if(result.at(1).compare("UnExistID") == 0)
				{
					Popup* toast = new Popup();
					toast->setStyle("toast");
					elm_object_text_set(toast->getContent(), "failed to login_UnExistID");
					toast->setTimeout(2.0);
				}
				else if(result.at(1).compare("WrongPW") == 0)
				{
					Popup* toast = new Popup();
					toast->setStyle("toast");
					elm_object_text_set(toast->getContent(), "failed to login_Wrong Password");
					toast->setTimeout(2.0);
				}
			} catch (exception e) {
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "failed to Network");
				toast->setTimeout(2.0);
			}
			delete mySocket;
		}
	};
	class RegisterBtn : public Button
	{
	private:
		Naviframe * mNaviframe;
	public:
		RegisterBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
		}
		void click()
		{
			new MyRegister(mNaviframe);
		}
	};
	class LoginView {
	private:
		bool textInEntryLogin;
		bool textInEntryPW;
		LoginBtn* loginbtn;
	public:
		LoginView() {
			loginbtn = 0;
			textInEntryPW = false;
			textInEntryLogin = false;
		}
		void setBoolLogin(bool b) {
			textInEntryLogin = b;
			btnEnable();
		}
		void setBoolPW(bool b) {
			textInEntryPW = b;
			btnEnable();
		}
		void btnEnable() {
			if(loginbtn == NULL)
				return;
			if (!textInEntryLogin && !textInEntryPW)
				loginbtn->setEnable();
			else
				loginbtn->setDisable();
		}
		void setLoginBtn(LoginBtn* lb)
		{
			loginbtn = lb;
		}
	};
	class PWEntry : public Entry
	{
	private:
		LoginView* loginview;
	public:
		PWEntry(UILayout parent, LoginView* lv) : Entry(parent) {
			loginview = lv;
		}
		void change()
		{
			if(!(this->isEmpty()))
				loginview->setBoolPW(false);
			else
				loginview->setBoolPW(true);
		}
	};
	class IDEntry : public Entry
	{
	private:
		LoginView* loginview;
	public:
		IDEntry(UILayout parent, LoginView* lv) : Entry(parent) {
			loginview = lv;
		}
		void change()
		{
			if(!(this->isEmpty()))
				loginview->setBoolLogin(false);
			else
				loginview->setBoolLogin(true);
		}
	};

private:
	FileIO* mFileIO;
	LoginView* mloginview;
	Background * mBg;

	Layout* mLayout;
	Layout* mIDLayout;
	Layout* mPwLayout;
	Box* mImgBox;
	Box* mInputBox;
	Box* mBtnBox;
	Label* mEmailLabel;
	IDEntry* mIDEntry;
	Label* mPwLabel;
	PWEntry* mPwEntry;

	LoginBtn* mLoginBtn;
	RegisterBtn* mSignupBtn;

	NaviItem mNaviItem;

	string mMyEdj;

protected:
	void drawUI(Naviframe * parentNavi){
		mloginview = new LoginView();
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		mNaviItem = parentNavi->addItem("Login",nullBtn,nullBtn,*mBg,"");
		mNaviItem.setTitleEnalble(FALSE, FALSE);
		mNaviItem.setFinalNavi();

		mLayout = new Layout(*mBg);
		mLayout->setEDCfile(mMyEdj);
		elm_object_content_set(mBg->getContent(),mLayout->getContent());


		mImgBox = new Box(*mLayout);


		mLayout->setContent("elm.swallow.icon", *mImgBox);
		//----------------//
		mInputBox = new Box(*mLayout);

		mEmailLabel = new Label(*mInputBox);
		mEmailLabel->setAlignHint(0.05, EVAS_HINT_FILL);
		mEmailLabel->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mEmailLabel->setText("<b>ID</b>");
		mInputBox->addBack(*mEmailLabel);

		mIDLayout = new Layout(*mInputBox);
		mIDLayout->setTheme("layout", "editfield", "singleline");
		mIDLayout->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mIDLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mInputBox->addBack(*mIDLayout);

		mIDEntry = new IDEntry(*mIDLayout, mloginview);
		mIDEntry->setSingleLine();
		mIDEntry->setScrollable();
		mIDEntry->setInputLayout(ELM_INPUT_PANEL_LAYOUT_NORMAL);
		mIDEntry->setInputReturnKeyTypeSet(ELM_INPUT_PANEL_RETURN_KEY_TYPE_NEXT);

		mIDLayout->setContent("elm.swallow.content", *mIDEntry);
		///
		mPwLabel = new Label(*mInputBox);
		mPwLabel->setAlignHint(0.05, EVAS_HINT_FILL);
		mPwLabel->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mPwLabel->setText("<b>Enter your password</b>");
		mInputBox->addBack(*mPwLabel);

		mPwLayout = new Layout(*mInputBox);
		mPwLayout->setTheme("layout", "editfield", "singleline");
		mPwLayout->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mPwLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mInputBox->addBack(*mPwLayout);

		mPwEntry = new PWEntry(*mPwLayout, mloginview);
		mPwEntry->setSingleLine();
		mPwEntry->setScrollable();
		mPwEntry->setPasswdMode();
		mPwEntry->setInputLayout(ELM_INPUT_PANEL_LAYOUT_PASSWORD);
		mPwEntry->setInputReturnKeyTypeSet(ELM_INPUT_PANEL_RETURN_KEY_TYPE_DONE);

		mPwLayout->setContent("elm.swallow.content", *mPwEntry);

		mLayout->setContent("elm.swallow.content", *mInputBox);

		//------------//
		mBtnBox = new Box(*mLayout);
		mBtnBox->setHorizontal();
		mBtnBox->setPadding(ELM_SCALE_SIZE(10), 0);

		mSignupBtn = new RegisterBtn(*mBtnBox,parentNavi);
		mSignupBtn->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mSignupBtn->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mSignupBtn->setText("Sign up");
		mBtnBox->addBack(*mSignupBtn);

		mLoginBtn = new LoginBtn(*mBtnBox,parentNavi,&mNaviItem,mIDEntry,mPwEntry);
		mLoginBtn->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mLoginBtn->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mLoginBtn->setText("Login");
		mLoginBtn->setDisable();
		mloginview->setLoginBtn(mLoginBtn);
		mBtnBox->addBack(*mLoginBtn);



		mLayout->setContent("elm.swallow.buttons", *mBtnBox);

		if(strcmp(mFileIO->get_buffer(), "%AUTO%")==0)
			mLoginBtn->click();
	}
	bool autoLogin(Naviframe * parentNavi){
		try{
			// ------------------------------파일 읽기---------------------------------------------
			FileInput input(LOGIN_FILE_NAME);
			string id = input.read();
			string pw = input.read();
			input.close();

			// ------------------------------앱 통신---------------------------------------------
			LoginSocket socket;
			char * tempStr = NULL;
			system_info_get_platform_string("http://tizen.org/system/tizenid",&tempStr);
			string deviceid = tempStr;

			vector<string> result = socket.autoLogin(id,pw,deviceid);

			if(result.at(0).compare("Success") == 0)
			{
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "Success to login");
				toast->setTimeout(2.0);

				mNaviItem.unSetFinalNavi();
				parentNavi->popItem();
				new Loding(parentNavi, id);

				return true;
			}
			else if(result.at(1).compare("WrongInfo") == 0)
			{
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "failed to login_WrongInfo");
				toast->setTimeout(2.0);

				return false;
			}
			else if(result.at(1).compare("WrongDevice") == 0)
			{
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "failed to login_WrongDevice");
				toast->setTimeout(2.0);

				return false;
			}
		}catch(const exception &e){
			return false;
		}
		return false;
	}

public:
	MyLogin(Naviframe * parentNavi){
		mLoginBtn = NULL;
		mNaviItem = NaviItem();
		mMyEdj = "login_layout";

		if(autoLogin(parentNavi) == false){
			drawUI(parentNavi);
		}
	}
};
const string MyLogin::LOGIN_FILE_NAME("login.txt");
