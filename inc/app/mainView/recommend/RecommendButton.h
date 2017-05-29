#pragma once

#include"RecommendSocket.h"
#include"RecommendPreferHoversel.h"
#include<string>

using namespace std;

class RecommendButton : public Button{
protected:
	RecommendPreferHoversel* preferFactor;
public:
	RecommendButton(UILayout parent, RecommendPreferHoversel* mHoverselPrefer):Button(parent){
		this->setText("추천");
		preferFactor=mHoverselPrefer;
	}

	void click(){
		dlog_print(DLOG_INFO, LOG_TAG, "(selected item : %s)", preferFactor->getItem()->getFactorName().c_str());

	//	RecommendSocket * socket = new RecommendSocket();

	}


};


