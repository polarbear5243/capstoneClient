S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 22259
Date: 2017-06-13 14:29:37+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 22259, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x000056f3
r2   = 0x00000006, r3   = 0xb41134c0
r4   = 0x00000002, r5   = 0xb4113000
r6   = 0xb680d09c, r7   = 0x0000010c
r8   = 0x00000001, r9   = 0xb5f3b708
r10  = 0xb8c4a6e8, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbeb94e7c
lr   = 0xb6703f18, pc   = 0xb6702b84
cpsr = 0x200d0010

Memory Information
MemTotal:   987012 KB
MemFree:    136328 KB
Buffers:     67664 KB
Cached:     240164 KB
VmPeak:     131772 KB
VmSize:     131696 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31604 KB
VmRSS:       28188 KB
VmData:      45688 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35864 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 22259 TID = 22259
22259 22260 22290 22291 22304 

Maps Information
af99b000 b019a000 rw-p [stack:22304]
b117a000 b118b000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b119b000 b11a0000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13cb000 b13d3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13e5000 b1be4000 rw-p [stack:22291]
b1be4000 b1be5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bf5000 b1c09000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c1d000 b1c1e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c2e000 b1c31000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c42000 b1c43000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c53000 b1c55000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c65000 b1c67000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c77000 b1c87000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c97000 b1ca3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cb5000 b24b4000 rw-p [stack:22290]
b27e5000 b27ec000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ff000 b2805000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2815000 b2846000 r-xp /opt/usr/apps/org.example.client/bin/client
b299f000 b2a82000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab9000 b2ae1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2af3000 b32f2000 rw-p [stack:22260]
b32f2000 b32f4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3304000 b330e000 r-xp /lib/libnss_files-2.20-2014.11.so
b331f000 b3328000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3339000 b334a000 r-xp /lib/libnsl-2.20-2014.11.so
b335d000 b3363000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3374000 b3375000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b339d000 b33a4000 r-xp /usr/lib/libminizip.so.1.0.0
b33b4000 b33b9000 r-xp /usr/lib/libstorage.so.0.1
b33c9000 b3428000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b343e000 b3452000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3462000 b34a6000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34b6000 b34be000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ce000 b34fe000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3511000 b35ca000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35de000 b3631000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3642000 b365d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b366d000 b372e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3741000 b3751000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3761000 b376e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b377f000 b3786000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3796000 b37d7000 r-xp /usr/lib/libmdm.so.1.2.12
b37e7000 b37ef000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37fe000 b380e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b382f000 b388f000 r-xp /usr/lib/libasound.so.2.0.0
b38a1000 b38a4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38b4000 b38b7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38c7000 b38cc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38dc000 b38dd000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ed000 b38f8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b390c000 b3913000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3923000 b3929000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3939000 b393e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b394e000 b3969000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3979000 b3980000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3990000 b3993000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39a4000 b39d2000 r-xp /usr/lib/libidn.so.11.5.44
b39e2000 b39f8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a09000 b3a13000 r-xp /usr/lib/libcares.so.2.1.0
b3a23000 b3a2d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a3d000 b3a3f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a4f000 b3a50000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a60000 b3a64000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a75000 b3a9d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aae000 b3ad7000 r-xp /usr/lib/libturbojpeg.so
b3af7000 b3afd000 r-xp /usr/lib/libgif.so.4.1.6
b3b0d000 b3b53000 r-xp /usr/lib/libcurl.so.4.3.0
b3b64000 b3b85000 r-xp /usr/lib/libexif.so.12.3.3
b3ba0000 b3bb5000 r-xp /usr/lib/libtts.so
b3bc6000 b3bce000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bde000 b3ca4000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cc4000 b3dbc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3ddb000 b3ea9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ec0000 b3ec2000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ed2000 b3ed8000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee8000 b3f0b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f1c000 b3f1e000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f2e000 b3f30000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f41000 b3f46000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f5d000 b3f5f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f6f000 b3f76000 r-xp /usr/lib/libsensord-share.so
b3f86000 b3f9e000 r-xp /usr/lib/libsensor.so.1.1.0
b3faf000 b3fb2000 r-xp /usr/lib/libXv.so.1.0.0
b3fc2000 b3fc7000 r-xp /usr/lib/libutilX.so.1.1.0
b3fd7000 b3fdc000 r-xp /usr/lib/libappcore-common.so.1.1
b3fec000 b3ff3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4006000 b400a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b401b000 b40f9000 r-xp /usr/lib/libCOREGL.so.4.0
b4119000 b411c000 r-xp /usr/lib/libuuid.so.1.3.0
b412c000 b4143000 r-xp /usr/lib/libblkid.so.1.1.0
b4154000 b4156000 r-xp /usr/lib/libXau.so.6.0.0
b4166000 b41ad000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41bf000 b41c5000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d6000 b41da000 r-xp /usr/lib/libogg.so.0.7.1
b41ea000 b420c000 r-xp /usr/lib/libvorbis.so.0.4.3
b421c000 b4300000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b431c000 b431f000 r-xp /usr/lib/libEGL.so.1.4
b4330000 b4336000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4346000 b4348000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4358000 b4365000 r-xp /usr/lib/libGLESv2.so.2.0
b4376000 b43d8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ed000 b4405000 r-xp /usr/lib/libmount.so.1.1.0
b4417000 b442b000 r-xp /usr/lib/libxcb.so.1.1.0
b443b000 b4442000 r-xp /lib/libcrypt-2.20-2014.11.so
b447a000 b447c000 r-xp /usr/lib/libiri.so
b448c000 b4497000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a8000 b44de000 r-xp /usr/lib/libpulse.so.0.16.2
b44ef000 b4532000 r-xp /usr/lib/libsndfile.so.1.0.25
b4547000 b455c000 r-xp /lib/libexpat.so.1.5.2
b456e000 b462c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4640000 b4648000 r-xp /usr/lib/libdrm.so.2.4.0
b4658000 b465b000 r-xp /usr/lib/libdri2.so.0.0.0
b466b000 b46b9000 r-xp /usr/lib/libssl.so.1.0.0
b46ce000 b46da000 r-xp /usr/lib/libeeze.so.1.13.0
b46eb000 b46f4000 r-xp /usr/lib/libethumb.so.1.13.0
b4704000 b4707000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4717000 b48ce000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b9000 b56c2000 r-xp /usr/lib/libXi.so.6.1.0
b56d2000 b56d4000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e4000 b56e8000 r-xp /usr/lib/libXtst.so.6.1.0
b56f8000 b56fe000 r-xp /usr/lib/libXrender.so.1.3.0
b570e000 b5714000 r-xp /usr/lib/libXrandr.so.2.2.0
b5724000 b5726000 r-xp /usr/lib/libXinerama.so.1.0.0
b5737000 b573a000 r-xp /usr/lib/libXfixes.so.3.1.0
b574a000 b5755000 r-xp /usr/lib/libXext.so.6.4.0
b5765000 b5767000 r-xp /usr/lib/libXdamage.so.1.1.0
b5777000 b5779000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5789000 b586b000 r-xp /usr/lib/libX11.so.6.3.0
b587f000 b5886000 r-xp /usr/lib/libXcursor.so.1.0.2
b5896000 b58ae000 r-xp /usr/lib/libudev.so.1.6.0
b58b0000 b58b3000 r-xp /lib/libattr.so.1.1.0
b58c3000 b58e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e4000 b58e9000 r-xp /usr/lib/libffi.so.6.0.2
b58fa000 b5912000 r-xp /lib/libz.so.1.2.8
b5922000 b5924000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5934000 b5a09000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1e000 b5ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad5000 b5ad8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae8000 b5b01000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b12000 b5b23000 r-xp /lib/libresolv-2.20-2014.11.so
b5b37000 b5bb1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc6000 b5bc8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd8000 b5bdf000 r-xp /usr/lib/libembryo.so.1.13.0
b5bef000 b5bf9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c0a000 b5c22000 r-xp /usr/lib/libpng12.so.0.50.0
b5c33000 b5c56000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c77000 b5c8b000 r-xp /usr/lib/libector.so.1.13.0
b5c9c000 b5cb4000 r-xp /usr/lib/liblua-5.1.so
b5cc5000 b5d1c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d30000 b5d58000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d69000 b5d7c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d8d000 b5dc7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dd8000 b5de6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5df6000 b5dfe000 r-xp /usr/lib/libtbm.so.1.0.0
b5e0e000 b5e1b000 r-xp /usr/lib/libeio.so.1.13.0
b5e2b000 b5e2d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e3d000 b5e42000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e52000 b5e69000 r-xp /usr/lib/libefreet.so.1.13.0
b5e7b000 b5e9b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eab000 b5ecb000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ecd000 b5ed3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ee3000 b5ef4000 r-xp /usr/lib/libemotion.so.1.13.0
b5f05000 b5f0c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f1c000 b5f2b000 r-xp /usr/lib/libeo.so.1.13.0
b5f3c000 b5f4e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f5f000 b5f64000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f74000 b5f8d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f9d000 b5fba000 r-xp /usr/lib/libeet.so.1.13.0
b5fd3000 b601b000 r-xp /usr/lib/libeina.so.1.13.0
b602c000 b603c000 r-xp /usr/lib/libefl.so.1.13.0
b604d000 b6132000 r-xp /usr/lib/libicuuc.so.51.1
b614f000 b628f000 r-xp /usr/lib/libicui18n.so.51.1
b62a6000 b62de000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f0000 b62f3000 r-xp /lib/libcap.so.2.21
b6303000 b632c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b633d000 b6344000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6356000 b638d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b639e000 b6489000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b649c000 b6515000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6527000 b652c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b653c000 b6546000 r-xp /usr/lib/libvconf.so.0.2.45
b6556000 b6558000 r-xp /usr/lib/libvasum.so.0.3.1
b6568000 b656a000 r-xp /usr/lib/libttrace.so.1.1
b657a000 b657d000 r-xp /usr/lib/libiniparser.so.0
b658d000 b65b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65c3000 b65c8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d9000 b65f0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6601000 b666c000 r-xp /lib/libm-2.20-2014.11.so
b667d000 b6683000 r-xp /lib/librt-2.20-2014.11.so
b6694000 b66a1000 r-xp /usr/lib/libunwind.so.8.0.1
b66d7000 b67fb000 r-xp /lib/libc-2.20-2014.11.so
b6810000 b6829000 r-xp /lib/libgcc_s-4.9.so.1
b6839000 b691b000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b692c000 b6956000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6967000 b69a3000 r-xp /usr/lib/libsystemd.so.0.4.0
b69a5000 b6a28000 r-xp /usr/lib/libedje.so.1.13.0
b6a3b000 b6a59000 r-xp /usr/lib/libecore.so.1.13.0
b6a79000 b6c00000 r-xp /usr/lib/libevas.so.1.13.0
b6c35000 b6c49000 r-xp /lib/libpthread-2.20-2014.11.so
b6c5d000 b6e91000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec0000 b6ec4000 r-xp /usr/lib/libsmack.so.1.0.0
b6ed4000 b6edb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eeb000 b6eed000 r-xp /usr/lib/libdlog.so.0.0.0
b6efd000 b6f00000 r-xp /usr/lib/libbundle.so.0.1.22
b6f10000 b6f12000 r-xp /lib/libdl-2.20-2014.11.so
b6f23000 b6f3b000 r-xp /usr/lib/libaul.so.0.1.0
b6f4f000 b6f54000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f65000 b6f72000 r-xp /usr/lib/liblptcp.so
b6f84000 b6f88000 r-xp /usr/lib/libsys-assert.so
b6f99000 b6fb9000 r-xp /lib/ld-2.20-2014.11.so
b6fca000 b6fcf000 r-xp /usr/bin/launchpad-loader
b88a1000 b8c82000 rw-p [heap]
beb75000 beb96000 rw-p [stack]
beb75000 beb96000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22259)
Call Stack Count: 1
 0: gsignal + 0x34 (0xb6702b84) [/lib/libc.so.6] + 0x2bb84
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
) > pid(804) status(0)
06-13 14:28:57.562+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18723775
06-13 14:28:57.562+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[101]  Y[142] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:28:57.562+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:28:57.562+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:28:57.572+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-13 14:28:57.572+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:28:57.572+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:28:57.732+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18723941
06-13 14:28:57.732+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18723941
06-13 14:28:57.842+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:28:57.862+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18724073
06-13 14:28:57.862+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[158]  Y[164] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:28:57.862+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:28:57.862+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:28:57.862+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-13 14:28:57.872+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:28:57.872+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:28:58.062+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18724273
06-13 14:28:58.062+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18724273
06-13 14:28:58.183+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:28:58.193+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18724394
06-13 14:28:58.193+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[219]  Y[161] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:28:58.193+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:28:58.193+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:28:58.193+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-13 14:28:58.203+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:28:58.203+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:28:58.643+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18724854
06-13 14:28:58.643+0900 I/MY_LOG  (22259): Button pressed
06-13 14:28:58.753+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18724953
06-13 14:28:58.753+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:28:58.763+0900 I/MY_LOG  (22259): Button unpressed
06-13 14:28:58.803+0900 D/basicui (22259): successed to load edc file
06-13 14:28:58.833+0900 I/MY_LOG  (22259): change
06-13 14:28:58.853+0900 I/MY_LOG  (22259): change
06-13 14:28:58.863+0900 I/MY_LOG  (22259): change
06-13 14:28:58.883+0900 I/MY_LOG  (22259): change
06-13 14:28:58.893+0900 I/MY_LOG  (22259): change
06-13 14:28:58.933+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:28:59.204+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:28:59.204+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:28:59.204+0900 I/ISE_MULTI(  804): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:true] mode=1[0m
06-13 14:28:59.214+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:28:59.214+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:28:59.234+0900 I/ISE_MULTI(  804): xt9-setting.cpp: xt9_change_onoff(157) > [0;36mPrediction ON[0m
06-13 14:28:59.234+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:28:59.234+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:28:59.254+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:28:59.254+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:28:59.274+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction(1498) > [0;36mGen prediction[0m
06-13 14:28:59.274+0900 W/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: refresh_lookup_table(4124) > [0;33mDo not need to insert.[0m
06-13 14:28:59.284+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:28:59.284+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.294+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:28:59.294+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 577[0m
06-13 14:28:59.334+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:28:59.434+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.444+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:28:59.534+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(3)
06-13 14:28:59.554+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:28:59.554+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:28:59.554+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:28:59.564+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:28:59.574+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:29:00.265+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:29:00.265+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:29
06-13 14:29:00.265+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:29"
06-13 14:29:00.265+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:29"
06-13 14:29:00.265+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:29:00.265+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146483117 Time: <font_size=31> </font_size> <font_size=31> 오후 2:29</font_size></font>"
06-13 14:29:01.165+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727368
06-13 14:29:01.165+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727368
06-13 14:29:01.266+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:01.296+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18727489
06-13 14:29:01.296+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[21]  Y[211] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:01.296+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:01.296+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:01.306+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:01.306+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:01.316+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:01.316+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:01.316+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:29:01.346+0900 I/ISE_MULTI(  804): isemain.cpp: slot_set_caps_mode(1028) > [0;36m[hidden state:false] mode=0[0m
06-13 14:29:01.456+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727666
06-13 14:29:01.456+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727666
06-13 14:29:01.546+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-13 14:29:01.566+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-13 14:29:01.566+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-13 14:29:01.576+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-13 14:29:01.586+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18727787
06-13 14:29:01.586+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[108]  Y[238] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:01.586+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:29:01.586+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:01.586+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:01.586+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:29:01.586+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:01.596+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:01.596+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.596+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.606+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.606+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:01.606+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 2[0m
06-13 14:29:01.726+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727931
06-13 14:29:01.726+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18727931
06-13 14:29:01.826+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18728019
06-13 14:29:01.826+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[169]  Y[241] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:01.826+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:01.826+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:01.836+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:01.836+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:01.856+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:01.936+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18728141
06-13 14:29:01.936+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18728141
06-13 14:29:02.046+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:02.076+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18728284
06-13 14:29:02.076+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[210]  Y[228] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:02.076+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:02.076+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:02.086+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:02.086+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:02.327+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_timer(159) > [0;36mprediction_gen_timer[0m
06-13 14:29:02.337+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Generate_prediction_TH(1695) > [0;36mGen prediction[0m
06-13 14:29:02.337+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: prediction_gen_thread(144) > [0;36mpredic gen set [1][0m
06-13 14:29:02.337+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 70[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_window_rotate(942) > [0;33mrotation[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(990) > [0;33m=== item_num = 9[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1046) > [0;33m i = 0, item_0_width = 210, total_width = 0[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: get_candidate(492) > [0;33mends[0m
06-13 14:29:02.347+0900 W/CANDIDATE(  804): soft_candidate.cpp: update_table_horizontal(1084) > [0;33m=== table.number_of_candidates() = 9, line_count = 3[0m
06-13 14:29:02.617+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18728817
06-13 14:29:02.707+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18728916
06-13 14:29:02.717+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:29:02.717+0900 I/SWIFTKEY(  713): swiftkey_engine.cpp: IME_Learn_sentence(2373) > [0;36mDLM write[0m
06-13 14:29:02.737+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:29:02.747+0900 I/ISE_MULTI(  804): xt9-setting.cpp: xt9_change_onoff(165) > [0;36mPrediction OFF[0m
06-13 14:29:02.777+0900 I/MY_LOG  (22259): change
06-13 14:29:02.827+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:29:02.827+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:29:02.827+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:29:02.827+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:29:02.827+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:29:02.827+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-13 14:29:02.837+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 577  rect->height : 505[0m
06-13 14:29:02.837+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:29:02.877+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:29:02.987+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:29:03.488+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18729705
06-13 14:29:03.508+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18729705
06-13 14:29:03.618+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:03.628+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18729838
06-13 14:29:03.628+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[37]  Y[138] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:03.628+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:03.638+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:03.638+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-13 14:29:03.638+0900 I/MY_LOG  (22259): change
06-13 14:29:03.638+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:03.638+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:03.838+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730048
06-13 14:29:03.838+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730048
06-13 14:29:03.938+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:03.958+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18730169
06-13 14:29:03.958+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[103]  Y[147] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:03.958+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:03.958+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:03.958+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-13 14:29:03.958+0900 I/MY_LOG  (22259): change
06-13 14:29:03.968+0900 I/MY_LOG  (22259): change
06-13 14:29:03.968+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:03.968+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:04.098+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730313
06-13 14:29:04.098+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730313
06-13 14:29:04.208+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:04.218+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18730435
06-13 14:29:04.218+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[177]  Y[150] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:04.218+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:04.218+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:04.228+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-13 14:29:04.228+0900 I/MY_LOG  (22259): change
06-13 14:29:04.228+0900 I/MY_LOG  (22259): change
06-13 14:29:04.228+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:04.228+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:04.278+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730491
06-13 14:29:04.278+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730491
06-13 14:29:04.359+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:04.399+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18730612
06-13 14:29:04.399+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[170]  Y[146] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:04.399+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:04.399+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:04.399+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-13 14:29:04.399+0900 I/MY_LOG  (22259): change
06-13 14:29:04.409+0900 I/MY_LOG  (22259): change
06-13 14:29:04.409+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:04.409+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:04.769+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18730981
06-13 14:29:04.869+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18731080
06-13 14:29:04.869+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:29:04.879+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:29:04.929+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is e0[0m
06-13 14:29:04.929+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is a0[0m
06-13 14:29:04.929+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 30[0m
06-13 14:29:04.929+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 20[0m
06-13 14:29:04.939+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 10[0m
06-13 14:29:04.979+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:29:04.979+0900 W/CANDIDATE(  804): soft_candidate.cpp: ui_candidate_hide(927) > [0;33mHide[0m
06-13 14:29:04.979+0900 E/ISE_MULTI(  804): ise.cpp: update_keyboard_geometry(598) > [0;31mg_main_window_rect.height 505  rect->height : 505[0m
06-13 14:29:05.019+0900 I/ISE_MULTI(  804): privatekeys.cpp: ise_update_Sym_private_key_for_lang(2283) > [0;36mSystem language is [ko_KR.UTF-8] #####[0m
06-13 14:29:05.099+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=0[0m
06-13 14:29:05.550+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18731762
06-13 14:29:05.550+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18731762
06-13 14:29:05.680+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:05.680+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18731872
06-13 14:29:05.680+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[41]  Y[159] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:05.680+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:05.680+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:05.690+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=1[0m
06-13 14:29:05.690+0900 I/MY_LOG  (22259): change
06-13 14:29:05.700+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:05.700+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:05.870+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732083
06-13 14:29:05.870+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732083
06-13 14:29:05.980+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:06.020+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18732237
06-13 14:29:06.030+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[93]  Y[142] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:06.030+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:06.030+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:06.030+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=2[0m
06-13 14:29:06.030+0900 I/MY_LOG  (22259): change
06-13 14:29:06.030+0900 I/MY_LOG  (22259): change
06-13 14:29:06.030+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:06.030+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:06.220+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732437
06-13 14:29:06.230+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732437
06-13 14:29:06.340+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:06.360+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18732559
06-13 14:29:06.360+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[167]  Y[146] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:06.360+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:06.360+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:06.371+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=3[0m
06-13 14:29:06.371+0900 I/MY_LOG  (22259): change
06-13 14:29:06.371+0900 I/MY_LOG  (22259): change
06-13 14:29:06.371+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:06.371+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:06.401+0900 I/MY_LOG  (22259): change
06-13 14:29:06.411+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732625
06-13 14:29:06.411+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18732625
06-13 14:29:06.511+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:06.521+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18732736
06-13 14:29:06.521+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[169]  Y[145] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:06.521+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:06.531+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:06.531+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-13 14:29:06.531+0900 I/MY_LOG  (22259): change
06-13 14:29:06.531+0900 I/MY_LOG  (22259): change
06-13 14:29:06.531+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:06.531+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:07.712+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18733920
06-13 14:29:07.712+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:29:07.712+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:29:07.812+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18734019
06-13 14:29:08.312+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18734524
06-13 14:29:08.312+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18734524
06-13 14:29:08.423+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18734612
06-13 14:29:08.423+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[584]  Y[-2] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:08.433+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:08.433+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is c0[0m
06-13 14:29:08.433+0900 I/MY_LOG  (22259): change
06-13 14:29:08.433+0900 I/MY_LOG  (22259): change
06-13 14:29:08.443+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:08.453+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=5[0m
06-13 14:29:08.453+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(804) status(0)
06-13 14:29:08.453+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:09.564+0900 E/EFL     (  342): ecore_x<342> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18735769
06-13 14:29:09.564+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18735769
06-13 14:29:09.584+0900 E/ISE_MULTI(  804): ise.cpp: on_event_key_clicked(1069) > [0;31mzero press_valuesX[659]  Y[347] aspect ratio is x[1.000000] y[1.000000][0m
06-13 14:29:09.584+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is f1[0m
06-13 14:29:09.594+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=0
06-13 14:29:09.594+0900 I/ISE_MULTI(  804): isemain.cpp: slot_update_cursor_position(1088) > [0;36m[hidden state:false] pos=4[0m
06-13 14:29:09.604+0900 I/MY_LOG  (22259): change
06-13 14:29:09.604+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=0
06-13 14:29:09.604+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is 60[0m
06-13 14:29:09.664+0900 E/EFL     (  804): ecore_x<804> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18735869
06-13 14:29:10.525+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=18736681
06-13 14:29:10.525+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=18736734
06-13 14:29:10.525+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:false][0m
06-13 14:29:10.555+0900 W/ISF_PANEL_EFL(  765): isf_panel_efl.cpp: efl_get_window_rotate_angle(3479) > WINDOW angle of 0x5800002 FAILED!
06-13 14:29:10.555+0900 I/SWIFTKEY(  713): isf_swiftkey_imengine.cpp: process_helper_event(4631) > [0;36m---- cmd is d0[0m
06-13 14:29:11.245+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=18737448
06-13 14:29:11.245+0900 I/MY_LOG  (22259): Button pressed
06-13 14:29:11.375+0900 E/EFL     (22259): ecore_x<22259> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=18737547
06-13 14:29:11.375+0900 I/ISE_MULTI(  804): isemain.cpp: slot_reset_ise_input_context(1280) > [0;36m[hidden state:true][0m
06-13 14:29:11.375+0900 I/MY_LOG  (22259): Button unpressed
06-13 14:29:30.914+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 14:29:31.515+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_rotation_event(485) > _ui_app_appcore_rotation_event
06-13 14:29:37.431+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:29:37.441+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:29:37.451+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:29:37.451+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:29:37.451+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:29:37.451+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:29:37.451+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 22259 pgid = 22259
06-13 14:29:37.451+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(22259)
06-13 14:29:37.501+0900 E/EFL     (  665): <665> lib/ecore_ipc/ecore_ipc.c:804 ecore_ipc_client_send() safety check failed: !ecore_con_client_connected_get(cl->client) is true
06-13 14:29:37.511+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:29:37.511+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:29:37.511+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:29:37.521+0900 I/Tizen::App( 1175): (243) > App[org.example.client] pid[22259] terminate event is forwarded
06-13 14:29:37.521+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:29:37.521+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [org.example.client, 22259, ]
06-13 14:29:37.521+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:29:37.521+0900 I/Tizen::App( 1175): (506) > TerminatedApp(org.example.client)
06-13 14:29:37.521+0900 I/Tizen::App( 1175): (512) > Not registered pid(22259)
06-13 14:29:37.521+0900 I/Tizen::System( 1175): (246) > Terminated app [org.example.client]
06-13 14:29:37.521+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:29:37.521+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 22259
06-13 14:29:37.521+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 22259
06-13 14:29:37.521+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 22259
06-13 14:29:37.521+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.2174
06-13 14:29:37.531+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(0)
06-13 14:29:37.541+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:29:37.541+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for org.example.client, 22259.
06-13 14:29:37.551+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:29:37.551+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:29:37.551+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:29:37.551+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:29:37.581+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [org.exampl] 
06-13 14:29:37.581+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:29:37.601+0900 W/CRASH_MANAGER(22313): worker.c: worker_job(1199) > 0622259636c69149733177
