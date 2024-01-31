package appsistema.controle;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;

public class actMenu extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_menu);
    }
    public boolean onCreateOptionsMenu(Menu menu){
        MenuInflater mninflater = getMenuInflater();
        mninflater.inflate(R.menu.menuprincipal);
    }
}