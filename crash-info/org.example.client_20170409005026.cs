S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 6770
Date: 2017-04-09 00:50:26+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6770, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xb6e37374
r2   = 0x0000005f, r3   = 0x00000065
r4   = 0xb837a008, r5   = 0xb6e37374
r6   = 0xb8288990, r7   = 0xb83ef120
r8   = 0x00000000, r9   = 0xb81a68d0
r10  = 0xb6e9deac, fp   = 0x00000000
ip   = 0xb5f321d8, sp   = 0xbea3aea0
lr   = 0xb5f1d6cd, pc   = 0xb67436f0
cpsr = 0xa0070030

Memory Information
MemTotal:   987012 KB
MemFree:    148088 KB
Buffers:     43676 KB
Cached:     335416 KB
VmPeak:     135476 KB
VmSize:     134372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29512 KB
VmRSS:       28808 KB
VmData:      46360 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35796 KB
VmPTE:         102 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6770 TID = 6770
6770 6771 6836 6837 6846 

Maps Information
af22e000 afa2d000 rw-p [stack:6846]
b0fbb000 b0fcc000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0fdc000 b0fe1000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b13e3000 b13eb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13fd000 b1bfc000 rw-p [stack:6837]
b1bfc000 b1bfd000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c0d000 b1c21000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c35000 b1c36000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c46000 b1c49000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c5a000 b1c5b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c6b000 b1c6d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c7d000 b1c7f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c8f000 b1c9f000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1caf000 b1cbb000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ccd000 b24cc000 rw-p [stack:6836]
b27fd000 b2804000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2817000 b281d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b282d000 b284d000 r-xp /opt/usr/apps/org.example.client/bin/client
b2996000 b2a79000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab0000 b2ad8000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2aea000 b32e9000 rw-p [stack:6771]
b32e9000 b32eb000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32fb000 b3305000 r-xp /lib/libnss_files-2.20-2014.11.so
b3316000 b331f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3330000 b3341000 r-xp /lib/libnsl-2.20-2014.11.so
b3354000 b335a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b336b000 b336c000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3394000 b339b000 r-xp /usr/lib/libminizip.so.1.0.0
b33ab000 b33b0000 r-xp /usr/lib/libstorage.so.0.1
b33c0000 b341f000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3435000 b3449000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3459000 b349d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34ad000 b34b5000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34c5000 b34f5000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3508000 b35c1000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35d5000 b3628000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3639000 b3654000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3664000 b3725000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3738000 b3748000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3758000 b3765000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3776000 b377d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b378d000 b37ce000 r-xp /usr/lib/libmdm.so.1.2.12
b37de000 b37e6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37f5000 b3805000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3826000 b3886000 r-xp /usr/lib/libasound.so.2.0.0
b3898000 b389b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38ab000 b38ae000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38be000 b38c3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38d3000 b38d4000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38e4000 b38ef000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3903000 b390a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b391a000 b3920000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3930000 b3935000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3945000 b3960000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3970000 b3977000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3987000 b398a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b399b000 b39c9000 r-xp /usr/lib/libidn.so.11.5.44
b39d9000 b39ef000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a00000 b3a0a000 r-xp /usr/lib/libcares.so.2.1.0
b3a1a000 b3a24000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a34000 b3a36000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a46000 b3a47000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a57000 b3a5b000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a6c000 b3a94000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aa5000 b3ace000 r-xp /usr/lib/libturbojpeg.so
b3aee000 b3af4000 r-xp /usr/lib/libgif.so.4.1.6
b3b04000 b3b4a000 r-xp /usr/lib/libcurl.so.4.3.0
b3b5b000 b3b7c000 r-xp /usr/lib/libexif.so.12.3.3
b3b97000 b3bac000 r-xp /usr/lib/libtts.so
b3bbd000 b3bc5000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bd5000 b3c9b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cbb000 b3db3000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dd2000 b3ea0000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3eb7000 b3eb9000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ec9000 b3ecf000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3edf000 b3f02000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f13000 b3f15000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f25000 b3f27000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f38000 b3f3d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f54000 b3f56000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f66000 b3f6d000 r-xp /usr/lib/libsensord-share.so
b3f7d000 b3f95000 r-xp /usr/lib/libsensor.so.1.1.0
b3fa6000 b3fa9000 r-xp /usr/lib/libXv.so.1.0.0
b3fb9000 b3fbe000 r-xp /usr/lib/libutilX.so.1.1.0
b3fce000 b3fd3000 r-xp /usr/lib/libappcore-common.so.1.1
b3fe3000 b3fea000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ffd000 b4001000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4012000 b40f0000 r-xp /usr/lib/libCOREGL.so.4.0
b4110000 b4113000 r-xp /usr/lib/libuuid.so.1.3.0
b4123000 b413a000 r-xp /usr/lib/libblkid.so.1.1.0
b414b000 b414d000 r-xp /usr/lib/libXau.so.6.0.0
b415d000 b41a4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41b6000 b41bc000 r-xp /usr/lib/libjson-c.so.2.0.1
b41cd000 b41d1000 r-xp /usr/lib/libogg.so.0.7.1
b41e1000 b4203000 r-xp /usr/lib/libvorbis.so.0.4.3
b4213000 b42f7000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4313000 b4316000 r-xp /usr/lib/libEGL.so.1.4
b4327000 b432d000 r-xp /usr/lib/libxcb-render.so.0.0.0
b433d000 b433f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b434f000 b435c000 r-xp /usr/lib/libGLESv2.so.2.0
b436d000 b43cf000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43e4000 b43fc000 r-xp /usr/lib/libmount.so.1.1.0
b440e000 b4422000 r-xp /usr/lib/libxcb.so.1.1.0
b4432000 b4439000 r-xp /lib/libcrypt-2.20-2014.11.so
b4471000 b4473000 r-xp /usr/lib/libiri.so
b4483000 b448e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b449f000 b44d5000 r-xp /usr/lib/libpulse.so.0.16.2
b44e6000 b4529000 r-xp /usr/lib/libsndfile.so.1.0.25
b453e000 b4553000 r-xp /lib/libexpat.so.1.5.2
b4565000 b4623000 r-xp /usr/lib/libcairo.so.2.11200.14
b4637000 b463f000 r-xp /usr/lib/libdrm.so.2.4.0
b464f000 b4652000 r-xp /usr/lib/libdri2.so.0.0.0
b4662000 b46b0000 r-xp /usr/lib/libssl.so.1.0.0
b46c5000 b46d1000 r-xp /usr/lib/libeeze.so.1.13.0
b46e2000 b46eb000 r-xp /usr/lib/libethumb.so.1.13.0
b46fb000 b46fe000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b470e000 b48c5000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b0000 b56b9000 r-xp /usr/lib/libXi.so.6.1.0
b56c9000 b56cb000 r-xp /usr/lib/libXgesture.so.7.0.0
b56db000 b56df000 r-xp /usr/lib/libXtst.so.6.1.0
b56ef000 b56f5000 r-xp /usr/lib/libXrender.so.1.3.0
b5705000 b570b000 r-xp /usr/lib/libXrandr.so.2.2.0
b571b000 b571d000 r-xp /usr/lib/libXinerama.so.1.0.0
b572e000 b5731000 r-xp /usr/lib/libXfixes.so.3.1.0
b5741000 b574c000 r-xp /usr/lib/libXext.so.6.4.0
b575c000 b575e000 r-xp /usr/lib/libXdamage.so.1.1.0
b576e000 b5770000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5780000 b5862000 r-xp /usr/lib/libX11.so.6.3.0
b5876000 b587d000 r-xp /usr/lib/libXcursor.so.1.0.2
b588d000 b58a5000 r-xp /usr/lib/libudev.so.1.6.0
b58a7000 b58aa000 r-xp /lib/libattr.so.1.1.0
b58ba000 b58da000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58db000 b58e0000 r-xp /usr/lib/libffi.so.6.0.2
b58f1000 b5909000 r-xp /lib/libz.so.1.2.8
b5919000 b591b000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b592b000 b5a00000 r-xp /usr/lib/libxml2.so.2.9.2
b5a15000 b5ab0000 r-xp /usr/lib/libstdc++.so.6.0.20
b5acc000 b5acf000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5adf000 b5af8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b09000 b5b1a000 r-xp /lib/libresolv-2.20-2014.11.so
b5b2e000 b5ba8000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bbd000 b5bbf000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bcf000 b5bd6000 r-xp /usr/lib/libembryo.so.1.13.0
b5be6000 b5bf0000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c01000 b5c19000 r-xp /usr/lib/libpng12.so.0.50.0
b5c2a000 b5c4d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c6e000 b5c82000 r-xp /usr/lib/libector.so.1.13.0
b5c93000 b5cab000 r-xp /usr/lib/liblua-5.1.so
b5cbc000 b5d13000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d27000 b5d4f000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d60000 b5d73000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d84000 b5dbe000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dcf000 b5ddd000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5ded000 b5df5000 r-xp /usr/lib/libtbm.so.1.0.0
b5e05000 b5e12000 r-xp /usr/lib/libeio.so.1.13.0
b5e22000 b5e24000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e34000 b5e39000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e49000 b5e60000 r-xp /usr/lib/libefreet.so.1.13.0
b5e72000 b5e92000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ea2000 b5ec2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ec4000 b5eca000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eda000 b5eeb000 r-xp /usr/lib/libemotion.so.1.13.0
b5efc000 b5f03000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f13000 b5f22000 r-xp /usr/lib/libeo.so.1.13.0
b5f33000 b5f45000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f56000 b5f5b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f6b000 b5f84000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f94000 b5fb1000 r-xp /usr/lib/libeet.so.1.13.0
b5fca000 b6012000 r-xp /usr/lib/libeina.so.1.13.0
b6023000 b6033000 r-xp /usr/lib/libefl.so.1.13.0
b6044000 b6129000 r-xp /usr/lib/libicuuc.so.51.1
b6146000 b6286000 r-xp /usr/lib/libicui18n.so.51.1
b629d000 b62d5000 r-xp /usr/lib/libecore_x.so.1.13.0
b62e7000 b62ea000 r-xp /lib/libcap.so.2.21
b62fa000 b6323000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6334000 b633b000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b634d000 b6384000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6395000 b6480000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6493000 b650c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b651e000 b6523000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6533000 b653d000 r-xp /usr/lib/libvconf.so.0.2.45
b654d000 b654f000 r-xp /usr/lib/libvasum.so.0.3.1
b655f000 b6561000 r-xp /usr/lib/libttrace.so.1.1
b6571000 b6574000 r-xp /usr/lib/libiniparser.so.0
b6584000 b65aa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65ba000 b65bf000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d0000 b65e7000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65f8000 b6663000 r-xp /lib/libm-2.20-2014.11.so
b6674000 b667a000 r-xp /lib/librt-2.20-2014.11.so
b668b000 b6698000 r-xp /usr/lib/libunwind.so.8.0.1
b66ce000 b67f2000 r-xp /lib/libc-2.20-2014.11.so
b6807000 b6820000 r-xp /lib/libgcc_s-4.9.so.1
b6830000 b6912000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6923000 b694d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b695e000 b699a000 r-xp /usr/lib/libsystemd.so.0.4.0
b699c000 b6a1f000 r-xp /usr/lib/libedje.so.1.13.0
b6a32000 b6a50000 r-xp /usr/lib/libecore.so.1.13.0
b6a70000 b6bf7000 r-xp /usr/lib/libevas.so.1.13.0
b6c2c000 b6c40000 r-xp /lib/libpthread-2.20-2014.11.so
b6c54000 b6e88000 r-xp /usr/lib/libelementary.so.1.13.0
b6eb7000 b6ebb000 r-xp /usr/lib/libsmack.so.1.0.0
b6ecb000 b6ed2000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ee2000 b6ee4000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef4000 b6ef7000 r-xp /usr/lib/libbundle.so.0.1.22
b6f07000 b6f09000 r-xp /lib/libdl-2.20-2014.11.so
b6f1a000 b6f32000 r-xp /usr/lib/libaul.so.0.1.0
b6f46000 b6f4b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f5c000 b6f69000 r-xp /usr/lib/liblptcp.so
b6f7b000 b6f7f000 r-xp /usr/lib/libsys-assert.so
b6f90000 b6fb0000 r-xp /lib/ld-2.20-2014.11.so
b6fc1000 b6fc6000 r-xp /usr/bin/launchpad-loader
b7fe6000 b8431000 rw-p [heap]
bea1b000 bea3c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6770)
Call Stack Count: 1
 0: (0xb67436f0) [/lib/libc.so.6] + 0x756f0
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
04-09 00:48:17.659+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:48:17.689+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:48:17.719+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:17.719+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:48:17.719+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:48:17.719+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:48:17.719+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:48:17.739+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 14
04-09 00:48:17.739+0900 W/AUL_AMD (  607): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-09 00:48:17.749+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:48:17.749+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6557]
04-09 00:48:17.759+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:48:17.759+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:17.769+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:17.779+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:48:17.799+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb8570610]
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:48:17.849+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb8570610
04-09 00:48:17.849+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:48:17.859+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:48:17.859+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:48:17.859+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:48:17.859+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:48:17.969+0900 E/VCONF   ( 5974): vconf-kdb.c: _vconf_kdb_del_notify(468) > Error: inotify_add_watch() [/opt/var/kdb/db/ise+keysound]: Permission denied
04-09 00:48:17.969+0900 E/VCONF   ( 5974): vconf.c: vconf_ignore_key_changed(3218) > vconf_ignore_key_changed() failed: key(db/ise/keysound)
04-09 00:48:18.009+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 5974 pgid = 5974
04-09 00:48:18.009+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(5974)
04-09 00:48:18.059+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:48:18.059+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:48:18.059+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:48:18.059+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 5974
04-09 00:48:18.059+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 5974
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[5974] terminate event is forwarded
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 5974, ]
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:48:18.059+0900 I/Tizen::App( 1246): (512) > Not registered pid(5974)
04-09 00:48:18.059+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:48:18.059+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:18.059+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.548
04-09 00:48:18.069+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:18.069+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 5974.
04-09 00:48:19.811+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:48:19.811+0900 E/PKGMGR_SERVER( 6554): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:48:21.723+0900 E/PKGMGR  ( 6646): pkgmgr.c: pkgmgr_client_reinstall(2020) > reinstall pkg start.
04-09 00:48:21.803+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: main(2414) > package manager server start
04-09 00:48:21.853+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.client]
04-09 00:48:21.863+0900 E/PKGMGR_SERVER( 6648): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-09 00:48:21.863+0900 E/PKGMGR  ( 6646): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[66460002]
04-09 00:48:22.003+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-09 00:48:22.003+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-09 00:48:22.013+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:48:22.023+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:48:22.143+0900 I/APP_CORE(  850): appcore-efl.c: __do_app(514) > [APP 850] Event: MEM_FLUSH State: PAUSED
04-09 00:48:22.183+0900 W/CERT_SVC_VCORE( 6651): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:48:22.273+0900 E/rpm-installer( 6651): coretpk-parser.c: _coretpk_parser_get_manifest_info(1183) > (doc == NULL) xmlParseFile() failed.
04-09 00:48:22.273+0900 E/rpm-installer( 6651): coretpk-installer.c: _coretpk_installer_verify_privilege_list(1594) > (pkg_file_info == NULL) pkg_file_info is NULL.
04-09 00:48:22.333+0900 E/PKGMGR_PARSER( 6651): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: connect(62) > Client connected
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-SERVER(  938): SocketService.cpp: mainloop(230) > Got incoming connection
04-09 00:48:22.353+0900 I/PRIVACY-MANAGER-CLIENT( 6651): SocketClient.cpp: disconnect(72) > Client disconnected
04-09 00:48:22.353+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-09 00:48:22.363+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-09 00:48:22.363+0900 E/PKGMGR_CERT( 6651): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-09 00:48:22.393+0900 E/rpm-installer( 6651): coretpk-installer.c: _coretpk_installer_package_reinstall(6347) > _coretpk_installer_package_reinstall(org.example.client) failed.
04-09 00:48:22.403+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: fail
04-09 00:48:22.403+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [fail], install = [1]
04-09 00:48:22.403+0900 E/ESD     (  919): esd_main.c: __esd_pkgmgr_event_callback(1757) > pkg_event(3) falied
04-09 00:48:22.403+0900 W/AUL_AMD (  607): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1111) > __amd_pkgmgrinfo_fail_handler
04-09 00:48:22.413+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _isf_insert_ime_info_by_pkgid(1168) > pkgmgrinfo_pkginfo_get_pkginfo("org.example.client",~) returned -1
04-09 00:48:22.413+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-09 00:48:22.533+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:22.644+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:22.644+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-09 00:48:23.815+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-09 00:48:24.095+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6651]
04-09 00:48:24.986+0900 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
04-09 00:48:25.016+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk]
04-09 00:48:25.026+0900 E/PKGMGR_INFO( 6648): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] not found in DB
04-09 00:48:25.036+0900 E/rpm-installer( 6648): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
04-09 00:48:25.036+0900 E/PKGMGR_SERVER( 6648): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
04-09 00:48:25.046+0900 E/PKGMGR  ( 6699): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[66990002]
04-09 00:48:25.166+0900 E/PKGMGR_INSTALLER( 6701): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
04-09 00:48:25.166+0900 E/rpm-installer( 6701): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.client-1.0.0-arm.tpk] is tpk package.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.176+0900 E/rpm-installer( 6701): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-09 00:48:25.176+0900 E/rpm-installer( 6701): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:48:25.226+0900 W/CERT_SVC_VCORE( 6701): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-09 00:48:25.276+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: install
04-09 00:48:25.276+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [start], Value = [install], install = [1]
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [30]
04-09 00:48:25.286+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-09 00:48:25.526+0900 E/rpm-installer( 6701): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-09 00:48:25.536+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-09 00:48:25.536+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-09 00:48:25.576+0900 I/PRIVACY-MANAGER-CLIENT( 6701): SocketClient.cpp: SocketClient(37) > Client created
04-09 00:48:25.777+0900 E/PKGMGR_PARSER( 6701): pkgmgr_parser.c: __check_theme(142) > theme for installation.
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 109
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 109
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 3
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 4
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 4
04-09 00:48:25.797+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 3
04-09 00:48:25.807+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-09 00:48:25.807+0900 E/PKGMGR_CERT( 6701): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [60]
04-09 00:48:25.817+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-09 00:48:25.827+0900 E/rpm-installer( 6701): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-09 00:48:25.847+0900 E/rpm-installer( 6701): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (119) > InstallationInProgress [100]
04-09 00:48:25.857+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [1]
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (1894) > PackageEventHandler - req: 12460002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (78) > Installation is Completed. [Package = org.example.client]
04-09 00:48:27.708+0900 I/Tizen::App( 1246): (671) > Enter. package(org.example.client), installationResult(0)
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-09 00:48:27.708+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-09 00:48:27.718+0900 I/Tizen::App( 1246): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-09 00:48:27.729+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6701]
04-09 00:48:27.729+0900 I/Tizen::App( 1246): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-09 00:48:27.749+0900 W/ISF_PANEL_EFL(  789): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:48:27.759+0900 E/PKGMGR_INFO( 1246): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-09 00:48:27.759+0900 I/Tizen::App( 1246): (683) > Application count(1) in this package
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (840) > Enter.
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (703) > Exit.
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [1]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (416) > appName = [client]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-09 00:48:27.769+0900 I/Tizen::App( 1246): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (131) > Enter
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-09 00:48:27.779+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (137) > org.example.client does not have launch condition
04-09 00:48:27.779+0900 I/Tizen::App( 1246): (883) > Exit.
04-09 00:48:27.789+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-09 00:48:27.789+0900 E/HOME_APPS(  868): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.client] mdm is not enabled
04-09 00:48:27.789+0900 E/cluster-home(  868): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-09 00:48:27.789+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-09 00:48:27.799+0900 E/util-view(  868): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-09 00:48:27.809+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-09 00:48:27.809+0900 E/PKGMGR_SERVER( 6648): pkgmgr-server.c: main(2471) > package manager server terminated.
04-09 00:48:27.829+0900 W/HOME_APPS(  868): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.912+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:30.922+0900 E/INDICATOR(  682): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-09 00:48:31.893+0900 W/AUL     ( 6757): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-09 00:48:31.893+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
04-09 00:48:31.903+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-09 00:48:31.913+0900 I/AUL     (  607): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-09 00:48:31.913+0900 E/AUL_AMD (  607): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-09 00:48:31.913+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 6757
04-09 00:48:31.913+0900 E/AUL_AMD (  607): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-09 00:48:31.913+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:48:31.913+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:48:31.923+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:48:31.923+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:48:31.923+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:48:31.933+0900 I/abc     ( 6408): abc
04-09 00:48:31.933+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:48:31.933+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:48:31.963+0900 E/TBM     ( 6408): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:48:32.023+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6408, appid: org.example.client
04-09 00:48:32.023+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:48:32.033+0900 W/AUL     ( 6757): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6408)
04-09 00:48:32.233+0900 D/basicui ( 6408): successed to load edc file
04-09 00:48:32.273+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:32.273+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:48:32.293+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:48:32.293+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:48:32.303+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:48:32.313+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:48:32.333+0900 I/MY_LOG  ( 6408): change
04-09 00:48:32.373+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(514) > [APP 6408] Event: RESET State: CREATED
04-09 00:48:32.373+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:48:32.383+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.383+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.393+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.393+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.393+0900 E/EFL     ( 6408): edje<6408> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:48:32.393+0900 E/EFL     ( 6408): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:48:32.403+0900 W/APP_CORE( 6408): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6c00002
04-09 00:48:32.403+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:48:32.523+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:48:32.523+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:48:32.533+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:48:32.533+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:48:32.533+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6408) status(3)
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:48:32.533+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:48:32.533+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6408)
04-09 00:48:32.533+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6408, appid: org.example.client, status: fg
04-09 00:48:32.533+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(514) > [APP 6408] Event: RESUME State: CREATED
04-09 00:48:32.543+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:48:32.543+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:48:32.543+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:48:32.553+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:48:32.553+0900 I/APP_CORE( 6408): appcore-efl.c: __do_app(625) > [APP 6408] Initial Launching, call the resume_cb
04-09 00:48:32.553+0900 I/CAPI_APPFW_APPLICATION( 6408): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:48:32.904+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6408) status(0)
04-09 00:48:33.084+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:48:33.084+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6408.
04-09 00:48:33.094+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.557
04-09 00:48:33.854+0900 I/UXT     ( 6770): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:48:37.538+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:48:41.102+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7658293
04-09 00:48:41.232+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7658426
04-09 00:48:41.292+0900 D/basicui ( 6408): successed to load edc file
04-09 00:48:41.312+0900 I/MY_LOG  ( 6408): change
04-09 00:48:41.322+0900 I/MY_LOG  ( 6408): change
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6408) : db/ise/keysound error
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:48:41.342+0900 E/VCONF   ( 6408): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:48:41.382+0900 I/MY_LOG  ( 6408): change
04-09 00:48:42.463+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7659652
04-09 00:48:42.463+0900 I/MY_LOG  ( 6408): Button pressed
04-09 00:48:42.563+0900 E/EFL     ( 6408): ecore_x<6408> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7659751
04-09 00:48:42.563+0900 I/MY_LOG  ( 6408): Button unpressed
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:49:00.971+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:49
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:49"
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:49"
04-09 00:49:00.971+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:49:00.971+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145566552 Time: <font_size=31> </font_size> <font_size=31> 오전 12:49</font_size></font>"
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(195) > ""
04-09 00:50:01.000+0900 E/UXT     (  682): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:50
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: getTimeFormatted(176) > "time format : 오전 12:50"
04-09 00:50:01.000+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:50"
04-09 00:50:01.010+0900 W/INDICATOR(  682): clock.c: indicator_clock_changed_cb(272) > 
04-09 00:50:01.010+0900 I/INDICATOR(  682): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145552188 Time: <font_size=31> </font_size> <font_size=31> 오전 12:50</font_size></font>"
04-09 00:50:10.639+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(3)
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-09 00:50:10.649+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-09 00:50:10.649+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(868)
04-09 00:50:10.649+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: fg
04-09 00:50:10.659+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6408 pgid = 6408
04-09 00:50:10.659+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(143) > dead_pid(6408)
04-09 00:50:10.709+0900 I/AUL_PAD ( 1481): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-09 00:50:10.709+0900 I/AUL_PAD ( 1481): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-09 00:50:10.709+0900 E/AUL_PAD ( 1481): launchpad.c: main(698) > error reading sigchld info
04-09 00:50:10.709+0900 I/ESD     (  919): esd_main.c: __esd_app_dead_handler(1773) > pid: 6408
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (243) > App[org.example.client] pid[6408] terminate event is forwarded
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (256) > osp.accessorymanager.service provider is found.
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (196) > Accessory Owner is removed [org.example.client, 6408, ]
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (256) > osp.system.service provider is found.
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (506) > TerminatedApp(org.example.client)
04-09 00:50:10.709+0900 I/Tizen::App( 1246): (512) > Not registered pid(6408)
04-09 00:50:10.709+0900 I/Tizen::System( 1246): (246) > Terminated app [org.example.client]
04-09 00:50:10.709+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:10.709+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6408
04-09 00:50:10.709+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6408
04-09 00:50:10.719+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.561
04-09 00:50:10.719+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(0)
04-09 00:50:10.719+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: RESUME State: PAUSED
04-09 00:50:10.719+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:10.719+0900 E/cluster-home(  868): homescreen.cpp: OnResume(233) >  app resume
04-09 00:50:10.729+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:10.729+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:10.729+0900 I/Tizen::App( 1246): (782) > Finished invoking application event listener for org.example.client, 6408.
04-09 00:50:10.749+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-09 00:50:10.759+0900 I/Tizen::System( 1246): (259) > Active app [com.samsun], current [org.exampl] 
04-09 00:50:10.759+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:10.789+0900 E/weather-widget( 1410): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-09 00:50:10.799+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
04-09 00:50:10.799+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:10.809+0900 I/TIZEN_N_SOUND_MANAGER(  933): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=15, ret=0x0
04-09 00:50:10.809+0900 E/TIZEN_N_SOUND_MANAGER(  933): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-09 00:50:10.809+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:10.819+0900 E/weather-common( 1410): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-09 00:50:10.849+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:10.849+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 0606408636c691491666610
04-09 00:50:10.899+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_create(409) > New handle created[0xb858a908]
04-09 00:50:10.909+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_get_type(463) > Connected Network = 2
04-09 00:50:10.909+0900 I/CAPI_NETWORK_CONNECTION( 1410): connection.c: connection_destroy(427) > Destroy handle: 0xb858a908
04-09 00:50:10.909+0900 E/weather-common( 1410): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-09 00:50:10.909+0900 E/weather-widget( 1410): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-09 00:50:10.909+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-09 00:50:10.909+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: fg
04-09 00:50:18.286+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7755485
04-09 00:50:18.707+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7755905
04-09 00:50:18.967+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:19.518+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7756711
04-09 00:50:19.728+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7756921
04-09 00:50:19.988+0900 W/cluster-view(  868): mainmenu-apps-view-impl.cpp: _OnScrollComplete(2308) >  booster timer is still running on apps-view, Stop boost timer!!!
04-09 00:50:20.999+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7758193
04-09 00:50:21.079+0900 E/EFL     (  868): ecore_x<868> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7758270
04-09 00:50:21.079+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
04-09 00:50:21.079+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 868
04-09 00:50:21.089+0900 E/RESOURCED(  684): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-09 00:50:21.089+0900 E/RESOURCED(  684): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-09 00:50:21.089+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-09 00:50:21.099+0900 W/AUL_PAD ( 1481): launchpad.c: __send_result_to_caller(267) > Check app launching
04-09 00:50:21.109+0900 I/abc     ( 6770): abc
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: ui_app_main(789) > app_efl_main
04-09 00:50:21.109+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-09 00:50:21.139+0900 E/TBM     ( 6770): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-09 00:50:21.199+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6770, appid: org.example.client
04-09 00:50:21.199+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-09 00:50:21.209+0900 W/AUL     (  868): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6770)
04-09 00:50:21.399+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.429+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-09 00:50:21.449+0900 I/Tizen::System( 1246): (259) > Active app [org.exampl], current [com.samsun] 
04-09 00:50:21.449+0900 I/Tizen::Io( 1246): (729) > Entry not found
04-09 00:50:21.459+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
04-09 00:50:21.459+0900 I/Tizen::System( 1246): (157) > change brightness system value.
04-09 00:50:21.489+0900 I/MY_LOG  ( 6770): change
04-09 00:50:21.530+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESET State: CREATED
04-09 00:50:21.530+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-09 00:50:21.540+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.540+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.550+0900 E/EFL     ( 6770): edje<6770> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-09 00:50:21.550+0900 E/EFL     ( 6770): By the power of Grayskull, your previous Embryo stack is now broken!
04-09 00:50:21.560+0900 W/APP_CORE( 6770): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:6400002
04-09 00:50:21.560+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 35
04-09 00:50:21.680+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: PAUSE State: RUNNING
04-09 00:50:21.680+0900 I/CAPI_APPFW_APPLICATION(  868): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-09 00:50:21.680+0900 E/cluster-home(  868): homescreen.cpp: OnPause(260) >  app pause
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(868) status(4)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(868)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 868, appid: com.samsung.homescreen, status: bg
04-09 00:50:21.690+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(514) > [APP 6770] Event: RESUME State: CREATED
04-09 00:50:21.690+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(3)
04-09 00:50:21.690+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.client(6770)
04-09 00:50:21.690+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6770, appid: org.example.client, status: fg
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-09 00:50:21.700+0900 I/CAPI_WIDGET_APPLICATION( 1410): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-09 00:50:21.700+0900 W/AUL     ( 1410): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1410, appid: com.samsung.weather-m-widget, status: bg
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-09 00:50:21.710+0900 I/APP_CORE( 6770): appcore-efl.c: __do_app(625) > [APP 6770] Initial Launching, call the resume_cb
04-09 00:50:21.710+0900 I/CAPI_APPFW_APPLICATION( 6770): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-09 00:50:22.050+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(6770) status(0)
04-09 00:50:22.260+0900 E/RESOURCED(  684): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.564
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (499) > LaunchedApp(org.example.client)
04-09 00:50:22.270+0900 I/Tizen::App( 1246): (733) > Finished invoking application event listener for org.example.client, 6770.
04-09 00:50:23.021+0900 I/UXT     ( 6842): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-09 00:50:23.481+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7760669
04-09 00:50:23.562+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7760757
04-09 00:50:23.622+0900 D/basicui ( 6770): successed to load edc file
04-09 00:50:23.642+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.652+0900 I/MY_LOG  ( 6770): change
04-09 00:50:23.672+0900 I/MY_LOG  ( 6770): change
04-09 00:50:24.593+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=7761787
04-09 00:50:24.603+0900 I/MY_LOG  ( 6770): Button pressed
04-09 00:50:24.693+0900 E/EFL     ( 6770): ecore_x<6770> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=7761886
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_check_retry_err(1368) > db/ise/keysound : check retry err (-21/13).
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key_filesys(2371) > _vconf_get_key_filesys(db/ise/keysound) step(-21) failed(13 / Permission denied) retry(0) 
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: _vconf_get_key(2407) > _vconf_get_key(db/ise/keysound) step(-21) failed(13 / Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_get_bool(2729) > vconf_get_bool(6770) : db/ise/keysound error
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf-kdb.c: _vconf_kdb_add_notify(318) > _vconf_kdb_add_notify : add noti(Permission denied)
04-09 00:50:24.703+0900 E/VCONF   ( 6770): vconf.c: vconf_notify_key_changed(3168) > vconf_notify_key_changed : key(db/ise/keysound) add notify fail
04-09 00:50:24.753+0900 I/MY_LOG  ( 6770): Button unpressed
04-09 00:50:24.843+0900 E/EFL     ( 6770): elementary<6770> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
04-09 00:50:26.695+0900 I/APP_CORE(  868): appcore-efl.c: __do_app(514) > [APP 868] Event: MEM_FLUSH State: PAUSED
04-09 00:50:27.045+0900 W/CRASH_MANAGER( 6784): worker.c: worker_job(1199) > 1106770636c69149166662
