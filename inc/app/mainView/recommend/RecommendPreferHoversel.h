#pragma once
#include"gui/object/Hoversel.h"
#include"RecommendFactor.h"

using namespace std;

class RecommendPreferHoversel : public Hoversel{
protected:
	RecommendFactor* factor;
public:
	RecommendPreferHoversel(UILayout parent, RecommendFactor* f):Hoversel(parent){
		this->setParent(this->getContent(), parent.getContent());
		this->setName("Prefer");
		this->addItem("맛");
		this->addItem("식재료");
		this->addItem("카테고리");

		this->addItem("나라");
		factor = f;
	}
	RecommendFactor* getItem(){
		return factor;
	}
	void clicked(){

	}
	void selected(){
		factor->factor2val(elm_object_item_text_get(NULL));
	}
	void dismissed(){

	}
};
