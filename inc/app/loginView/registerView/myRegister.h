/*
 * MyWindow.h
 *
 *  Created on: Mar 15, 2017
 *      Author: 제경
 */

#pragma once
#include"gui/object/Label.h"
#include"gui/layout/Box.h"
#include"gui/layout/Conformant.h"
#include"gui/layout/Naviframe.h"
#include"gui/object/Entry.h"
#include"gui/layout/Layout.h"
#include"gui/layout/Background.h"
#include"gui/object/popup.h"
#include"app/AppParser.h"
#include<string>
#include<vector>
using namespace std;




class MyRegister
{
	class RegisterSocket{
	protected:
		AppSocket * mSocket;
	public:
		RegisterSocket(){
			mSocket = new AppSocket();
		}
		vector<string> regeister(string id, string pw){
			vector<string> msg;
			msg.push_back("Login");
			msg.push_back("Register");
			msg.push_back(id);
			msg.push_back(pw);

			mSocket->sendData(AppParser::wrapMsg(msg));
			msg = AppParser::parsingMsg(mSocket->receiveData());

			return msg;
		}
		~RegisterSocket(){
			delete mSocket;
		}
	};
	class CancleBtn : public Button
	{
	private:
		Naviframe * mNaviframe;
	public:
		CancleBtn(UILayout parent, Naviframe * naviframe) : Button(parent) {
			mNaviframe = naviframe;
		}
		void click()
		{
			mNaviframe->popItem();
		}
	};

	class RegBtn : public Button
	{
	private:
		Entry * mLoginEntry;
		Entry * mPWEntry;
		Entry * mReEntry;
		Naviframe * mNaviframe;

		RegisterSocket * mRegSocket;
	public:
		RegBtn(UILayout parent, Naviframe * naviframe, Entry * loginEntry, Entry * pwEntry, Entry * reEntry) : Button(parent) {
			mLoginEntry = loginEntry;
			mPWEntry = pwEntry;
			mReEntry = reEntry;
			mNaviframe = naviframe;
		}
		void click()
		{
			mRegSocket = new RegisterSocket;

			string id = mLoginEntry->getText();
			string pw = mPWEntry->getText();
			string re = mReEntry->getText();

			if(id.length() > 15){
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "ID는 15자 이하로 만들어 주세요.");
				toast->setTimeout(2.0);
			}
			else if(pw.compare(re) == 0){
				vector<string> result = mRegSocket->regeister(id,pw);

				if(result.at(0).compare("Success") == 0){
					Popup* toast = new Popup();
					toast->setStyle("toast");
					elm_object_text_set(toast->getContent(), "Success to register");
					toast->setTimeout(2.0);

					mNaviframe->popItem();
				} else if(result.at(1).compare("ExistID") == 0){
					Popup* toast = new Popup();
					toast->setStyle("toast");
					elm_object_text_set(toast->getContent(), "이미 존재하는 ID 입니다.");
					toast->setTimeout(2.0);
				}
			}
			else{
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "비밀전호가 일치하지 않습니다.");
				toast->setTimeout(2.0);
			}
			delete mRegSocket;
		}
	};
private:
	MyRegister* mMyRegister;
	Background* mBg;
	Layout* mLayout;
	Layout* mIDLayout;
	Layout* mPwLayout;
	Layout* mRePwLayout;
	Box* mImgBox;
	Box* mInputBox;
	Box* mBtnBox;
	Label* mEmailLabel;
	Entry* mIDEntry;
	Label* mPwLabel;
	Label* mRePwLabel;
	Entry* mPwEntry;
	Entry* mRePwEntry;

	CancleBtn * mCancleBtn;
	RegBtn * mSignupBtn;

	string mMyEdj;
public:
	MyRegister(Naviframe * parentNavi){
		mMyEdj = "login_layout";
		drawUI(parentNavi);
	}
protected:
	void drawUI(Naviframe * parentNavi){
		mBg = new Background(*parentNavi);
		mBg->setColor(255,255,255);

		Button nullBtn;
		parentNavi->addItem("Register",nullBtn,nullBtn,*mBg,"").setTitleEnalble(FALSE, FALSE);

		mLayout = new Layout(*parentNavi);
		elm_object_content_set(mBg->getContent(),mLayout->getContent());

		mLayout->setEDCfile(mMyEdj);
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

		mIDEntry = new Entry(*mIDLayout);
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

		mPwEntry = new Entry(*mPwLayout);
		mPwEntry->setSingleLine();
		mPwEntry->setScrollable();
		mPwEntry->setPasswdMode();
		mPwEntry->setInputLayout(ELM_INPUT_PANEL_LAYOUT_PASSWORD);
		mPwEntry->setInputReturnKeyTypeSet(ELM_INPUT_PANEL_RETURN_KEY_TYPE_DONE);

		mPwLayout->setContent("elm.swallow.content", *mPwEntry);

		///
		mRePwLabel = new Label(*mInputBox);
		mRePwLabel->setAlignHint(0.05, EVAS_HINT_FILL);
		mRePwLabel->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mRePwLabel->setText("<b>Re enter your password</b>");
		mInputBox->addBack(*mRePwLabel);

		mRePwLayout = new Layout(*mInputBox);
		mRePwLayout->setTheme("layout", "editfield", "singleline");
		mRePwLayout->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		mRePwLayout->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mInputBox->addBack(*mRePwLayout);

		mRePwEntry = new Entry(*mRePwLayout);
		mRePwEntry->setSingleLine();
		mRePwEntry->setScrollable();
		mRePwEntry->setPasswdMode();
		mRePwEntry->setInputLayout(ELM_INPUT_PANEL_LAYOUT_PASSWORD);
		mRePwEntry->setInputReturnKeyTypeSet(ELM_INPUT_PANEL_RETURN_KEY_TYPE_DONE);

		mRePwLayout->setContent("elm.swallow.content", *mRePwEntry);

		mLayout->setContent("elm.swallow.content", *mInputBox);

		//------------//
		mBtnBox = new Box(*mLayout);
		mBtnBox->setHorizontal();
		mBtnBox->setPadding(ELM_SCALE_SIZE(10), 0);

		mCancleBtn = new CancleBtn(*mBtnBox,parentNavi);
		mCancleBtn->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mCancleBtn->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		//callback
		mCancleBtn->setText("Cancel");
		mBtnBox->addBack(*mCancleBtn);

		mSignupBtn = new RegBtn(*mBtnBox,parentNavi,mIDEntry,mPwEntry,mRePwEntry);
		mSignupBtn->setAlignHint(EVAS_HINT_FILL, EVAS_HINT_FILL);
		mSignupBtn->setWeightHint(EVAS_HINT_EXPAND, 0.0);
		//callback mSignupBtn->
		mSignupBtn->setText("Sign up");
		mBtnBox->addBack(*mSignupBtn);

		mLayout->setContent("elm.swallow.buttons", *mBtnBox);
	}
};
