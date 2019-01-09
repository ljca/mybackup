package test.check;

import android.app.Activity;
import android.os.Bundle;
import android.widget.Toast;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.CompoundButton.OnCheckedChangeListener;

public class CheckBoxTest extends Activity{

  private CheckBox check1 = null;
  private CheckBox check2 = null;
  private CheckBox check3 = null;
  private CheckBox check4 = null;
  private CheckBox check5 = null;

  /** Called when the activity is first created. */
  @Override
  public void onCreate(Bundle savedInstanceState){
	super.onCreate(savedInstanceState);
	setContentView(R.layout.main);
	check1 = (CheckBox)findViewById(R.id.check_1);
	check2 = (CheckBox)findViewById(R.id.check_2);
	check3 = (CheckBox)findViewById(R.id.check_3);
	check4 = (CheckBox)findViewById(R.id.check_4);
	check5 = (CheckBox)findViewById(R.id.check_5);

	check1.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
		// TODO Auto-generated method stub
		if(isChecked){
		  Toast.makeText(CheckBoxTest.this, "CheckBox1 Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  Toast.makeText(CheckBoxTest.this, "CheckBox1 Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	check2.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
		// TODO Auto-generated method stub
		if(isChecked){
		  Toast.makeText(CheckBoxTest.this, "CheckBox2 Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  Toast.makeText(CheckBoxTest.this, "CheckBox2 Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	check3.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
		// TODO Auto-generated method stub
		if(isChecked){
		  Toast.makeText(CheckBoxTest.this, "CheckBox3 Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  Toast.makeText(CheckBoxTest.this, "CheckBox3 Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	check4.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
		// TODO Auto-generated method stub
		if(isChecked){
		  Toast.makeText(CheckBoxTest.this, "CheckBox4 Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  Toast.makeText(CheckBoxTest.this, "CheckBox4 Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

	check5.setOnCheckedChangeListener(new OnCheckedChangeListener(){
	  public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
		// TODO Auto-generated method stub
		if(isChecked){
		  Toast.makeText(CheckBoxTest.this, "CheckBox5 Selected!", Toast.LENGTH_SHORT).show();
		}else{
		  Toast.makeText(CheckBoxTest.this, "CheckBox5 Unselected!", Toast.LENGTH_SHORT).show();
		}
	  }
	});

  }
}
