#pragma once
#include <string>

using namespace std;

class RecommendFactor{
private:
	string factor_name;
	int taste_val;
	int grocery_val;
	int category_val;
	int nation_val;
public:
	RecommendFactor(){
		factor_name="DEFAULT";
		taste_val=0;
		grocery_val=0;
		category_val=0;
		nation_val=0;
	}
	void factor2val(string factor){
		if(factor=="맛"){
			taste_val=2;
			grocery_val=1;
			category_val=1;
			nation_val=1;
		}
		else if(factor=="식재료"){
			taste_val=1;
			grocery_val=2;
			category_val=1;
			nation_val=1;
		}
		else if(factor=="카테고리"){
			taste_val=1;
			grocery_val=1;
			category_val=2;
			nation_val=1;
		}
		else if(factor=="나라"){
			taste_val=1;
			grocery_val=1;
			category_val=1;
			nation_val=2;
		}
		else{
			taste_val=0;
			grocery_val=0;
			category_val=0;
			nation_val=0;
		}
	}
	string getFactorName(){
		return factor_name;
	}
	int getTasteVal(){
		return taste_val;
	}
	int getGroceryVal(){
		return grocery_val;
	}
	int getCategoryVal(){
		return category_val;
	}
	int getNationVal(){
		return nation_val;
	}
};
