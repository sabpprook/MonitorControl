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
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;

public class SettingFragment extends Fragment {

    private View view;
    private SharedPreferences sp;
    private EditText editHost, editPort;

    public SettingFragment() {}

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        view = inflater.inflate(R.layout.fragment_setting, container, false);
        sp = PreferenceManager.getDefaultSharedPreferences(getContext());

        Toolbar toolbar = view.findViewById(R.id.toolbar_setting);
        toolbar.setNavigationOnClickListener(view1 -> {
            NavController navCtrl = Navigation.findNavController(getActivity(), R.id.fragmentContainerView);
            navCtrl.navigateUp();
        });

        editHost = view.findViewById(R.id.editText_Host);
        editPort = view.findViewById(R.id.editText_Port);
        editHost.setText(sp.getString("MRC_Host", "127.0.0.1"));
        editPort.setText(sp.getString("MRC_Port", "7999"));

        return view;
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();

        SharedPreferences.Editor editor = sp.edit();
        editor.putString("MRC_Host", editHost.getText().toString());
        editor.putString("MRC_Port", editPort.getText().toString());
        editor.apply();
    }
}