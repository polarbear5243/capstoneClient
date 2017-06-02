#pragma once
#include"gui/object/Entry.h"
#include<string>

#include"SurveySocket.h"

using namespace std;

class SurveyEntry : public Entry{
protected:
	string mRecipeId;
	int mCounter;

public:
	SurveyEntry(UILayout parent):Entry(parent){
		mCounter=6;
		setEntry();
	}

	void setEntry(){
		mCounter--;
		mRecipeId = SurveySocket().getRandRecipe();
		this->setMultLine();
		writeRecipeInfo();
		this->setDisable();
	}

	string getRecipeId(){
		return mRecipeId;
	}

	int getCounter(){
		return mCounter;
	}

protected:
	void writeRecipeInfo(){
		this->setEnable();
		SurveySocket * socket = new SurveySocket();

		vector<string> msg = socket->getRecipe(mRecipeId);
		string info = "";

		int i=0;
		info = info + "ID      :  " + msg[i++] + "<br/>";
		info = info + "이름        :  " + msg[i++] + "<br/>";
		info = info + "나라        :  " + msg[i++] + "<br/>";
		info = info + "분류        :  " + msg[i++] + "<br/>";
		info = info + "시간(분) :  " + msg[i++] + "<br/>";
		info = info + "열량        :  " + msg[i++] + "<br/>";
		info = info + "난이도     :  " + msg[i++] + "<br/>";
		info = info + "재료" + "<br/>";
		while(msg[i] != "End"){
			info = info + msg[i] + ", ";
			i++;
		}
		i++;

		info = info + "<br/>" + "조리법" + "<br/>";

		int start_i = i;
		while(msg[i] != "End"){

			char index[20];
			sprintf(index,"%d",i-start_i+1);

			info = info + index + ". " + msg[i] + "<br/>";
			i++;
		}

		this->setText(info);
	}
};
