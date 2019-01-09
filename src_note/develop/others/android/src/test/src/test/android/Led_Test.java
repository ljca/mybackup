package test.android;

import android.app.Activity;
import android.os.Bundle;
import android.widget.TextView;
import android.widget.Button;
import android.view.View.OnClickListener;
import android.view.View;

public class Led_Test extends Activity{
		TextView txt;
		Button btn_on,btn_off;
		OnClickListener onClk;
    /** Called when the activity is first created. */
    @Override
    public void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.main);
		txt = (TextView)findViewById(R.id.txt);
		txt.setText("TextView");

		btn_on = (Button)findViewById(R.id.btn_on);
		btn_on.setText("ON");

		btn_off = (Button)findViewById(R.id.btn_off);
		btn_off.setText("OFF");

		onClk = new OnClickListener(){
			public void onClick(View v){
				if(v == btn_on){
					txt.setText("button click ON");
				}else if(v == btn_off){
					txt.setText("button click OFF");
				}
			}
		};
		btn_on.setOnClickListener(onClk);
		btn_off.setOnClickListener(onClk);
    }
}
