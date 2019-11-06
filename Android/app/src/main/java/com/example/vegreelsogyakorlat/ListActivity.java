package com.example.vegreelsogyakorlat;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.ListView;

public class ListActivity extends AppCompatActivity {

    String[] months =new String[]{"Január","Február","Március","Április","Május","Junius","Julius","Agusztus","Szeptember","Oktober","November","December"};

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list);
        ListView listView =findViewById(R.id.ListViewListActivity);
        ArrayAdapter<String> adapter =new ArrayAdapter<>(this,android.R.layout.simple_list_item_1,months);
        listView.setAdapter(adapter);

    }
}
