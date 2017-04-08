#pragma once

class BreakCycle{
private:
	static BreakCycle * mInstance;
public:
	static BreakCycle * getInstance(){
		return mInstance;
	}
public:
	BreakCycle(){
		mInstance = this;
	}
	virtual void deleteFoodItem(void * itemPointer){

	}
};
BreakCycle * BreakCycle::mInstance = NULL;
