#pragma once
#include"gui/object/Hoversel.h"

using namespace std;

class RecommendPreferHoversel : public Hoversel{
protected:
	string mName;
public:
	RecommendPreferHoversel(UILayout parent, Evas_Object *obj, string name):Hoversel(parent){
		this->setParent(this->getContent(), obj);
		this->addItem("맛");
		this->addItem("식재료");
		this->addItem("카테고리");
		this->addItem("나라");

		this->setName(name);
		mName = name;
	}

	void selected(void * event_info){
		string name = elm_object_item_part_text_get((Elm_Widget_Item *)event_info,NULL);
		this->setName(name);
		mName = name;
	}

	string getName(){
		return mName;
	}
};
