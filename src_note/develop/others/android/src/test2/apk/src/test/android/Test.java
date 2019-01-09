package test.android;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;
import android.widget.Button;
import android.view.View.OnClickListener;
import android.view.View;
import jar.Tool;

public class Test extends Activity{
		TextView txt;
		Button btn_on,btn_off;
		OnClickListener onClk;

	//	native int add(int a,int b);
	//	native int sub(int a,int b);
	//	static{
	//		System.loadLibrary("test");
	//	};
	Tool tool;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
		txt = (TextView)findViewById(R.id.txt);
		//txt.setText("TextView");

		btn_on = (Button)findViewById(R.id.btn_on);
		btn_on.setText("ADD");

		btn_off = (Button)findViewById(R.id.btn_off);
		btn_off.setText("SUB");

		onClk = new OnClickListener(){
			public void onClick(View v){
				tool = new Tool();
				if(v == btn_on){
					//txt.setText("button click ON");
					txt.setText(String.valueOf(tool.add(5,26)));
				}else if(v == btn_off){
					//txt.setText("button click OFF");
					txt.setText(String.valueOf(tool.sub(20,8)));
				}
			}
		};
		btn_on.setOnClickListener(onClk);
		btn_off.setOnClickListener(onClk);
    }
}
