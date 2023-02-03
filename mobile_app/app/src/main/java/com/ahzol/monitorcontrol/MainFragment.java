package com.ahzol.monitorcontrol;

import android.content.SharedPreferences;
import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.appcompat.widget.Toolbar;
import androidx.fragment.app.Fragment;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;

import android.preference.PreferenceManager;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.Toast;

public class MainFragment extends Fragment {

    private View view;
    private SharedPreferences sp;

    public MainFragment() {}

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_main, container, false);
        sp = PreferenceManager.getDefaultSharedPreferences(getContext());

        Toolbar toolbar = view.findViewById(R.id.toolbar_main);
        toolbar.setOnMenuItemClickListener(item -> {
            if (item.getItemId() == R.id.menu_settings) {
                NavController navCtrl = Navigation.findNavController(getActivity(), R.id.fragmentContainerView);
                navCtrl.navigate(R.id.settingFragment);
                return true;
            }
            return false;
        });

        ImageButton btnPower = view.findViewById(R.id.imgBtn_Power);
        Button btnDisplayPort1 = view.findViewById(R.id.button_DisplayPort1);
        Button btnDisplayPort2 = view.findViewById(R.id.button_DisplayPort2);
        Button btnHdmi1 = view.findViewById(R.id.button_HDMI1);
        Button btnHdmi2 = view.findViewById(R.id.button_HDMI2);
        btnPower.setOnClickListener(buttonClickEvent);
        btnDisplayPort1.setOnClickListener(buttonClickEvent);
        btnDisplayPort2.setOnClickListener(buttonClickEvent);
        btnHdmi1.setOnClickListener(buttonClickEvent);
        btnHdmi2.setOnClickListener(buttonClickEvent);

        return view;
    }

    private View.OnClickListener buttonClickEvent = view -> {
        String message;
        switch (view.getId()) {
            case R.id.imgBtn_Power:
                message = "[MRC]:PowerSwitch";
                break;
            case R.id.button_DisplayPort1:
                message = "[MRC]:DisplayPort_1";
                break;
            case R.id.button_DisplayPort2:
                message = "[MRC]:DisplayPort_2";
                break;
            case R.id.button_HDMI1:
                message = "[MRC]:HDMI_1";
                break;
            case R.id.button_HDMI2:
                message = "[MRC]:HDMI_2";
                break;
            default:
                message = "";
                break;
        }

        Toast.makeText(getContext(), message, Toast.LENGTH_SHORT).show();

        String mrcHost = sp.getString("MRC_Host", "127.0.0.1");
        String mrcPort = sp.getString("MRC_Port", "7999");
        TcpClient client = new TcpClient(mrcHost, Integer.parseInt(mrcPort));
        client.SendMessage(message);
    };
}