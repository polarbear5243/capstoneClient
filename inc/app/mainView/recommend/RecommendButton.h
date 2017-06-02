#pragma once

#include"RecommendPreferHoversel.h"
#include"RecommendList.h"

#include<string>

using namespace std;

class RecommendButton : public Button{
protected:
	RecommendPreferHoversel* prefer[4];
	RecommendList* mList;
public:
	RecommendButton(UILayout parent,
			RecommendPreferHoversel* prefer1,
			RecommendPreferHoversel* prefer2,
			RecommendPreferHoversel* prefer3,
			RecommendPreferHoversel* prefer4,
			RecommendList* list):Button(parent){

		this->setText("추천");

		prefer[0] = prefer1;
		prefer[1] = prefer2;
		prefer[2] = prefer3;
		prefer[3] = prefer4;
		mList = list;
	}

	void click(){
		int like[4] = {0,};

		UserInfo * user = UserInfo::getInstance();
		string userid = user->getMyId();

		//우선순위 계산

		string name;

		for(int i=0;i<4;i++){
			name = prefer[i]->getName();

			if(like[nameToNum(name)] == 0)
				like[nameToNum(name)] = i+1;
			else{
				//MSG
				Popup* toast = new Popup();
				toast->setStyle("toast");
				elm_object_text_set(toast->getContent(), "순위는 중복이 없어야 합니다.");
				toast->setTimeout(1.0);
				return;
			}
		}

		mList->refresh(like);
	}

protected:
	int nameToNum(string name){
		if(name.compare("맛")==0)
			return 0;
		if(name.compare("식재료")==0)
			return 1;
		if(name.compare("카테고리")==0)
			return 2;
		if(name.compare("나라")==0)
			return 3;
	}
};


