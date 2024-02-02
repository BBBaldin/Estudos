package applanchonete.console;

import androidx.appcompat.app.AppCompatActivity;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.fragment.app.FragmentTransaction;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.CheckBox;
import android.widget.ImageView;
import android.widget.RadioButton;
import android.widget.Toast;

import applanchonete.console.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {

    ImageView imgPrincipal;
    RadioButton rdbXburguer, rdbXsalada, rdbXtudo;
    CheckBox chkMaionese, chkBacon, chkCheddar;
    private String lanche, opcionais;
    private int total=0;

    ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        binding.nav.setOnItemSelectedListener(item -> {
            switch (item.getItemId()){
                case R.id.home:
                    replaceFragment(new HomeFragment());
                    break;
                case R.id.profile:
                    replaceFragment(new ProfileFragment());
                    break;
                case R.id.settigns:
                    replaceFragment(new SettingsFragment());
                    break;
            }
            return true;
        });


        imgPrincipal=findViewById(R.id.imgPrincipal);
        rdbXburguer=findViewById(R.id.rdbXburguer);
        rdbXsalada=findViewById(R.id.rdbXsalada);
        rdbXtudo=findViewById(R.id.rdbXtudo);
        chkMaionese=findViewById(R.id.chkMaionese);
        chkBacon=findViewById(R.id.chkBacon);
        chkCheddar=findViewById(R.id.chkCheddar);
    }
    private void replaceFragment (Fragment fragment){
        FragmentManager fragmentManager = getSupportFragmentManager();
        FragmentTransaction fragmentTransaction = fragmentManager.beginTransaction();
        FragmentTransaction.replace(R.id.framelayout,fragment);
        FragmentTransaction.commit();
    }
    public void Confirmar(View view) {
        if (rdbXburguer.isChecked()){
            lanche="X Burguer - R$ 10,00";
            total=total + 10;
        } else if (rdbXsalada.isChecked()) {
            lanche="X Salada - R$ 15,00";
            total=total + 15;
        } else if (rdbXtudo.isChecked()) {
            lanche="X Tudo - R$ 20,00";
            total=total + 20;
        }
        else {
            Toast.makeText(this, "Lanche não selecionado", Toast.LENGTH_SHORT).show();
        }
        opcionais="";
        if (chkMaionese.isChecked()){
            opcionais=opcionais + " Maionese - R$ 1,00 \n";
            total=total + 1;
        }
        if (chkBacon.isChecked()) {
            opcionais=opcionais + " Bacon - R$ 2,00 \n";
            total=total + 2;
        }
        if (chkCheddar.isChecked()) {
            opcionais=opcionais + " Cheddar - R$ 3,00 \n";
            total=total + 3;
        }
        if (!chkMaionese.isChecked() && !chkBacon.isChecked() && !chkCheddar.isChecked()){
            opcionais=" Sem Opcionais";
        }
        Intent it = new Intent(this, actPedido1.class);
        it.putExtra("lanche", lanche);
        it.putExtra("opcionais", opcionais);
        it.putExtra("total", String.valueOf(total));
        startActivity(it);
    }
}