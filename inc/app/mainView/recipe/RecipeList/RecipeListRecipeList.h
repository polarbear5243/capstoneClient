#pragma once
#include <app/mainView/recipe/RecipeList/RecipeListSocket.h>
#include<gui/object/List.h>
#include"gui/layout/Naviframe.h"

#include"RecipeListRecipeItem.h"

using namespace std;

class RecipeListRecipeList : public List{
protected:
	vector<RecipeListRecipeItem *> mListItem;
	Naviframe * mNavi;
	string mStr;

public:
	RecipeListRecipeList(UILayout parent, Naviframe * navi):List(parent) {
		mNavi = navi;
		mStr = "";
		refresh();
	}
	void searchRecipe(string str){
		mStr=str;
		refresh();
	}
	void refresh() {
		this->clear();

		//리스트 초기화
		for(int i=0;i<mListItem.size();i++){
			delete mListItem.at(i);
		}
		mListItem.clear();

		vector<string> reciveStr;
		RecipeListSocket * socket = new RecipeListSocket();
		RecipeListRecipeItem * tmp;

		//레시피 검색
		if(mStr.compare("") == 0)
			reciveStr = socket->getAllRecipe();
		else
			reciveStr = socket->searchRecipe(mStr);

		int i=1;
		string id;
		string name;
		while(true){
			id = reciveStr.at(i);
			if(id.compare("End") == 0)
				break;
			name = reciveStr.at(i+1);
			tmp = new RecipeListRecipeItem(name,id,mNavi);
			mListItem.push_back(tmp);
			this->addItem(tmp);
			i+=2;
		}

	}
	~RecipeListRecipeList(){
		for(int i=0;i<mListItem.size();i++){
			delete mListItem.at(i);
		}
		mListItem.clear();
	}
};
