package led.test;

import android.app.Activity;
import android.os.Bundle;
import android.widget.Toast;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.CompoundButton.OnCheckedChangeListener;

public class Led extends Activity{

  native int ledon(int ledarg);
  native int ledoff(int ledarg);
  native int buzon();
  native int buzoff();

  static{
	System.loadLibrary("tiny4412led");
  };

  private CheckBox led1 = null;
  private CheckBox led2 = null;
  private CheckBox led3 = null;
  private CheckBox led4 = null;
  private CheckBox buz = null;

  /** Called when the activity is first created. */
  @Override
  public void onCreate(Bundle savedInstanceState){
	super.onCreate(savedInstanceState);
	setContentView(R.layout.main);
	led1 = (CheckBox)findViewById(R.id.check_led1);
	led2 = (CheckBox)findViewById(R.id.check_led2);
	led3 = (CheckBox)findViewById(R.id.check_led3);
	led4 = (CheckBox)findViewById(R.id.check_led4);
	buz = (CheckBox)findViewById(R.id.check_buz);

	led1.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked){
		if(isChecked){
		  if(ledon(1) == -1){
			Toast.makeText(Led.this, "misc driver is not loadding! open device file error!", Toast.LENGTH_SHORT).show();
			return;
		  }
		  Toast.makeText(Led.this, "Led1 has Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  if(ledoff(1) == -1){
			return;
		  }
		  Toast.makeText(Led.this, "Led1 has Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	led2.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked){
		if(isChecked){
		  if(ledon(2) == -1){
			Toast.makeText(Led.this, "misc driver is not loadding! open device file error!", Toast.LENGTH_SHORT).show();
			return;
		  }
		  Toast.makeText(Led.this, "Led2 has Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  if(ledoff(2) == -1){
			return;
		  }
		  Toast.makeText(Led.this, "Led2 has Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	led3.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked){
		if(isChecked){
		  if(ledon(3) == -1){
			Toast.makeText(Led.this, "misc driver is not loadding! open device file error!", Toast.LENGTH_SHORT).show();
			return;
		  }
		  Toast.makeText(Led.this, "Led3 has Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  if(ledoff(3) == -1){
			return;
		  }
		  Toast.makeText(Led.this, "Led3 has Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	led4.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked){
		if(isChecked){
		  if(ledon(4) == -1){
			Toast.makeText(Led.this, "misc driver is not loadding! open device file error!", Toast.LENGTH_SHORT).show();
			return;
		  }
		  Toast.makeText(Led.this, "Led4 has Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  if(ledoff(4) == -1){
			return;
		  }
		  Toast.makeText(Led.this, "Led4 has Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	buz.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked){
		if(isChecked){
		  if(buzon() == -1){
			Toast.makeText(Led.this, "misc driver is not loadding! open device file error!", Toast.LENGTH_SHORT).show();
			return;
		  }
		  Toast.makeText(Led.this, "Buzzer has Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  if(buzoff() == -1){
			return;
		  }
		  Toast.makeText(Led.this, "Buzzer has Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

  }
}

