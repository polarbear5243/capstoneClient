#pragma once
#include<gui/object/List.h>
#include"gui/layout/Naviframe.h"
#include"app/DataModel/UserInfo.h"

#include "RecommendListItem.h"
#include "RecommendSocket.h"

using namespace std;

class RecommendList : public List{

	class EmptyListItem : public ListItem{
	public:
		EmptyListItem() : ListItem("") { }
	};

protected:
	vector<RecommendListItem *> mListItem;
	Naviframe * mNavi;

public:
	RecommendList(UILayout parent, Naviframe * navi):List(parent) {
		mNavi = navi;
		this->addItem(new EmptyListItem);
	}
	void refresh(int like[4]) {
		this->clear();

		//리스트 초기화
		for(int i=0;i<mListItem.size();i++){
			delete mListItem.at(i);
		}
		mListItem.clear();

		vector<string> reciveStr;
		RecommendSocket * socket = new RecommendSocket();
		RecommendListItem * tmp;

		//레시피 검색
		UserInfo * user = UserInfo::getInstance();
		string userId = user->getMyId();

		reciveStr = socket->getRecommendRecipe(userId,like);

		int i=1;
		string id;
		string name;
		while(true){
			id = reciveStr.at(i);
			const char * debug = id.c_str();

			if(id.compare("End") == 0)
				break;
			name = reciveStr.at(i+1);
			tmp = new RecommendListItem(name,id,mNavi);
			mListItem.push_back(tmp);
			this->addItem(tmp);
			i+=2;
		}
	}
	~RecommendList(){
		for(int i=0;i<mListItem.size();i++){
			delete mListItem.at(i);
		}
		mListItem.clear();
	}
};
