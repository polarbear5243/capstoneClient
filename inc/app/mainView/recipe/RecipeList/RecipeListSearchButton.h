#include"gui/object/Button.h"
#include"gui/object/Entry.h"

#include"RecipeListRecipeList.h"

#include<string>

using namespace std;

class RecipeListSearchButton : public Button{
private:
	Entry * mSearchEntry;
	RecipeListRecipeList * mRecipeList;

public:
	RecipeListSearchButton(UILayout parent, Entry * searchEntry, RecipeListRecipeList * recipelist): Button(parent){
		mSearchEntry = searchEntry;
		mRecipeList = recipelist;
		this->setText("검색");
	}
	void click(){
		if(mSearchEntry == NULL || mRecipeList == NULL)
			return;
		mRecipeList->searchRecipe(mSearchEntry->getText());
	}
};
