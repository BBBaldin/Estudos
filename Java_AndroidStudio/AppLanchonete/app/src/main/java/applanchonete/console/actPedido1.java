package applanchonete.console;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.TextView;

public class actPedido1 extends AppCompatActivity {

    TextView txtPedido, txtTotal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_act_pedido);
        txtPedido=findViewById(R.id.txtPedido);
        txtTotal=findViewById(R.id.txtTotal);
        Intent itorigem = getIntent();
        txtPedido.setText(itorigem.getStringExtra("lanche") + "\n" + itorigem.getStringExtra("opcionais"));
        txtTotal.setText("RS " + itorigem.getStringExtra("total") + ",00");
    }
}