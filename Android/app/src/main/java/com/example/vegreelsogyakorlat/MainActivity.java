package com.example.vegreelsogyakorlat;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity  implements View.OnClickListener{

    Button button;
    EditText editTextName , editTextPassword;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        button=findViewById(R.id.LoginButton);
        button.setOnClickListener(this);

        editTextName =findViewById(R.id.UsernameMainActivity);
        editTextPassword=findViewById(R.id.PasswordMainActivity);


    }

    @Override
    public void onClick(View v) {
        switch (v.getId()){
            case R.id.LoginButton:
                String name =editTextName.getText().toString();
                String password =editTextPassword.getText().toString();

                if(name.equals("Márk")&& password.equals("asd")){
                    Intent intent =new Intent(this,ListActivity.class);
                    startActivity(intent);
                }
                else {
                    editTextName.setText("");
                    editTextPassword.setText("");
                }
                break;

        }
    }
}
